
var index = {

    logar: function () {

        var dados = {

            usuario: getValById("usuario"),
            senha: getValById("senha")
        }

        if (dados.usuario.trim() == "" || dados.senha.trim() == ""){

            alert("Os campos são obrigatorios");
            return;
        }

        fd.ajax("POST", "Login/Logar", dados, function (retorno) {

            if (retorno.operacao) {
                alert(retorno.msg);
            }
            else {
                alert(retorno.msg);
            }

        }, function () {
            alert("Não foi possivel processar");
        });
    }

    

    
}