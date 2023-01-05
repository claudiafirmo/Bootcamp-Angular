let moment = require('moment');

moment.locale("pt-BR");

let now = moment();
console.log(now);
console.log(now.format("DD/MM/yyyy"));
console.log(now.format("DD/MM/yyyy - dddd - (MMMM)"));