function listar() {
    $.ajax({
        dataType: "json",
        url: "http://localhost:5192/api/guest/",
        method: "GET",
        success: function (resposta) {
            $("#tabela > tbody:has(tr)").empty();
            $.each(resposta, function (index, item) {
                $("#tabela > tbody").append(`<tr>
                    <td>${item.id}</td>
                    <td>${item.cpf}</td>
                    <td>${item.nome}</td>
                    <td>${item.email}</td>
                    <td><button type="button" class="btn btn-danger" onclick="remover(${item.id})">Remover</button>
                </tr>`)
            });
        },
        error: function (erro) {
            alert(erro.responseText);
        }

    });
}

function remover(id) {
    if (window.confirm("Tem certeza que deseja remover esse convidado?")) {
        $.ajax({
            dataType: "json",
            url: "http://localhost:5192/api/guest/" + id,
            method: "DELETE"
        }).done(function () {
            listar();
        });
    }
}

$(document).ready(function () {
    listar();
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
                listar();
            },
            error: function (erro) {
                $("#resposta").addClass("alert alert-error");
                $("#resposta").html(erro.responseText);
            }
        });
    });
});