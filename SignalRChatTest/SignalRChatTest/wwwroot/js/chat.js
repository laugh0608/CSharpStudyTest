﻿"use strict";

// 创建并启动连接
var connection = new signalR.HubConnectionBuilder().withUrl("/Chat").build();

// Disable the send button until connection is established.
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${user} : ${message}`;
});

// 向“提交”按钮添加一个用于向中心发送消息的处理程序
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

// 向连接对象添加一个用于从中心接收消息并将其添加到列表的处理程序
document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

// 在中心方法中引发的异常会发送到调用方法的客户端
// invoke 方法会返回 JavaScript Promise
// 客户端可以将 catch 处理程序附加到返回的承诺，或使用和 try/catch 和 async/await 来处理异常
// 意外异常通常包含敏感信息，例如在数据库连接失败时触发的异常中会包含数据库服务器的名称
// 作为安全措施，SignalR 在默认情况下不会公开这些详细错误消息
try {
    await connection.invoke("SendMessage", user, message);
} catch (err) {
    console.error(err);
}