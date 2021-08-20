
const host = 'http://192.168.0.152/api';
const endpoint = host + "/Veiculos"

//list all
function List()
{
    let request = new XMLHttpRequest();
    request.open("GET", endpoint);
    request.send();
    request.onload = function ()
    {
        console.log(request.status);
        let lista = JSON.parse(this.responseText);
        console.log(lista)
        let tabela = document.getElementById("table-veiculos");
        let corpo = tabela.getElementsByTagName("tbody")[0];
        corpo.innerHTML = "";
        lista.forEach(c=> {
            let linha = `<tr>
            <td>${c.id}</td>
            <td>${c.name}</td>
            <td>${c.type}</td>
        </tr>`;
        corpo.innerHTML +=linha;
        });
    }
}
function cadastrar()
{
    let id = document.getElementById("id").value;
    let name= document.getElementById("name").value;
    let type= document.getElementById("type").value;
    let model = {"Name":name, "Type":type};
    create(model);
}
function create(model)
{
    console.log(model)
    let request = new XMLHttpRequest();
    request.open("POST", endpoint);
    request.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    request.send(JSON.stringify(model));
    request.onload = function()
    {
        console.log(request.status);
    }
}
