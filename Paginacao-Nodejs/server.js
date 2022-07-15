const express = require("express");

const users = [{
    id: 1,
    name: "Valdirene Aparecida",
    surname: "Ferreira"
},
{
    id: 2,
    name: "Joelmir Rogério",
    surname: "Carvalho"
},
{
    id: 3,
    name: "Maria Lídia",
    surname: "Ferreira Carvalho"
},
{
    id: 4,
    name: "Noelly Cristina",
    surname: "Ferreira Carvalho"
},
{
    id: 5,
    name: "Antony Bennedito",
    surname: "Ferreira Carvalho"
},
{
    id: 6,
    name: "Maria do Rosário",
    surname: "Alves Carvalho"
},
{
    id: 7,
    name: "Gerônimo Eustáquio",
    surname: "Carvalho"
},
{
    id: 8,
    name: "Alex José",
    surname: "Carvalho"
},
{
    id: 9,
    name: "Rita de Cássia",
    surname: "Carvalho"
},
{
    id: 10,
    name: "Hugo Jhonatan",
    surname: "Carvalho"
},
{
    id: 11,
    name: "Lucas Daniel",
    surname: "Carvalho"
}]

const posts = [
    { name: "Post-1" },
    { name: "Post-2" },
    { name: "Post-3" },
    { name: "Post-4" },
    { name: "Post-5" },
    { name: "Post-6" },
    { name: "Post-7" },
    { name: "Post-8" },
    { name: "Post-9" },
    { name: "Post-10" },
    { name: "Post-11" },
    { name: "Post-12" },
    { name: "Post-13" },
    { name: "Post-14" },
    { name: "Post-15" }
]

const app = express();
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(express.static(`${__dirname}/img`));

app.get("/posts", paginatedResult(posts), (req, res) => {
    res.paginatedResult(res.post)
})

app.get("/users", paginatedResult(users), (req, res) => {
    res.json(res.paginatedResult)
})
// app.get("/users", (req, res) => {
//     const page = parseInt(req.query.page);
//     const limit = parseInt(req.query.limit);

//     const startIndex = (page - 1) * limit;
//     const endIndex = page * limit;

//     const data = {};

// if (endIndex < users.length)
//     data.next = {
//         page: page + 1,
//         limit
//     }
//     if (startIndex > 0)
//         data.previous = {
//             page: page - 1,
//             limit
//         }

//     data.results = users.slice(startIndex, endIndex);
//     res.send(data);
// })

function paginatedResult(model) {
    return (req, res, next) => {
        const page = parseInt(req.query.page);
        const limit = parseInt(req.query.limit);

        const startIndex = (page - 1) * limit;
        const endIndex = page * limit;

        const data = {};

        if (endIndex < model.length)
            data.next = {
                page: page + 1,
                limit
            }

        if (startIndex > 0)
            data.previous = {
                page: page - 1,
                limit
            }

        data.results = model.slice(startIndex, endIndex);
        res.send(data);
    }
}

app.listen(2000, () => {
    console.log("Servidor rodando na porta 2000...")
})