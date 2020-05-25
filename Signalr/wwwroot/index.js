let connection = null;

setupConnection = () => {
    //'/counthub ' 与Startup中的要一致 路由
    connection = new signalR.HubConnectionBuilder()
        .withUrl("/counthub")//回落自动选择连接机制
        //.withUrl("/counthub", signalR.HttpTransportType.LongPolling)//signalR.HttpTransportType.LongPolling:指定某种机制（这里指定的是LongPolling）
        .build();

    //定义后台可调用的几个方法
    connection.on("ReceiveUpdate", (update) => {
        const resultDiv = $("#result");
        resultDiv.html("ReceiveUpdate:" + update);
        //const resultDiv = document.getElementById("result");
        //resultDiv.innerHTML = "ReceiveUpdate:" + update;
    });

    connection.on("someFunc", function (obj) {
        const resultDiv = $("#result");
        resultDiv.html("someFunc:" + obj.random);
    });


    connection.on("Finished", function (update) {
        const resultDiv = $("#result");
        resultDiv.html("finished:" + update);
    });

    connection.on("Test_1", function (data) {
        const resultDiv = $("#result");
        resultDiv.html("Test:" + data.data);
    })

    //开始连接
    connection.start()
        .catch(err => console.log(err.toString()));

}
start = () => {
    try {
        if (connection.connectionState == "Disconnected") {
            //开始连接
            connection.start()
                .catch(err => console.log(err.toString()));
        }
    } catch (e) {
        console.log("sb");
    }
}
setupConnection();

$("#submit").click(function () {
    start();
    setTimeout(function () {
        fetch("/api/count",
            {
                method: "POST",
                headers: {
                    'content-type': 'application/json'
                }
            })
            .then(response => response.text())
            .then(id => connection.invoke("GetLatestCount", id))
            .then(function () {
                if (connection.connectionState == "Connected") {
                    //断开连接
                    connection.stop();
                }
            })
    }, 20)


})