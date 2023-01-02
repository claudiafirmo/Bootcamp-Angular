$(document).ready(function () {
    // instrução para adicionar um novo convidado
    $("#btnIncluir").click(function () {

        if ($("#resposta").hasClass("alert alert-success")) {
            $("#resposta").removeClass("alert alert-success");
        }

        if ($("#resposta").hasClass("alert alert-error")) {
            $("#resposta").removeClass("alert alert-error");
        }

        $.ajax({
            headers: {
                "Accept": "application/json",
                "Content-Type": "application/json"
            },
            dataType: "json",
            url: "http://localhost:5192/api/guest/",
            method: "POST",
            data: JSON.stringify({
                cpf: $("#cpf").val(),
                nome: $("#nome").val(),
                email: $("#email").val()
            }),
            success: function (resposta) {
                $("#resposta").addClass("alert alert-success");
                $("#resposta").html("Convidado incluido com sucesso!");
            },
            error: function (erro) {
                $("#resposta").addClass("alert alert-error");
                $("#resposta").html(erro.responseText);
            }
        });
    });
});