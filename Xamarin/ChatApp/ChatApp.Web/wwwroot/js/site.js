const { signalR } = require("../lib/aspnet-signalr/signalr");


(function () {
    var txtMessage = $('#txtMessage')
    var btnSend = $('#btnSend')
    var listMessage = $('#listMessage')
    var connection = new signalR.HubConnectionBuilder().withURL('/chathub').build();
    var userName = $('#userName').val();

    $(btnSend).click(function () {
        var userMessage = $(txtMessage).val();

        connection.invoke('SendMessage', {
            userNAme: userName,
            message: userMessage
        }).catch(function (error) {
            alert("Cant send the message.");
            console(error);
        })
        $(txtMessage).val('');
    });
  
    connection.start().then(function () {
        console.log('Conected to the signalr hub.');
        $(btnSend).removeAttr('disabled');
    })

    connection.on("ReceiveMessage", function (obj) {
        $(listMessage).propend('<li>['
            + obj.timeStampString + ']'
            + ' <span class="font-weight-bold">user: ' + obj.username
            + '</span> | message ' + obj.message
            + '</li>')
    })
})();