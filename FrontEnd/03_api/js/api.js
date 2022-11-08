$(document).ready(function(){
    $('#btnBuscar').click(function(){
        $.ajax({
            dataType: 'json',
            url: `https://jsonplaceholder.typicode.com/users`,
            method: 'GET',
            success: function(resposta){
                console.log(resposta)
                $('#tabela > tbody:has(tr)').empty();
               $.each(resposta, function(indice, item){
                    $('tbody').append(`<tr>
                        <td>${item.id}</td>
                        <td>${item.name}</td>
                        <td>${item.username}</td>
                        <td>${item.email}</td>
                        <td>${item.phone}</td>
                        <td>${item.address.street}, ${item.address.suite}, ${item.address.city}</td>
                        </tr><br>`)
               });
            },
            error: function(erro){
                alert(erro.responseText)
            }
        })
    });
});