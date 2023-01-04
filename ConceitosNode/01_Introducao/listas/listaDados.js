// devemos exportar a lista para que seja consumida em outro lugar (exports != export)
exports.nomes = ["José Carlos", "Daniela", "Marcos", "Júlia", "Bernardo", "Ana Paula"];

let cursos = [
    {
        descricao: 'Psicologia',
        ch: 4800,
        periodo: 'Manhã',
    },
    {
        descricao: 'ADS',
        ch: 2400,
        periodo: 'Noite'
    },
    {
        descricao: 'Turismo',
        ch: 3200,
        periodo: 'Integral'
    }
];

// Objeto a ser exportado
exports.escola = {
    nome: 'Impacta Tecnologia',
    endereco: {
        logradouro: 'Avenida Paulista',
        numero: 1009,
        cidade: 'São Paulo'
    },
    alunos: this.nomes, // exports.nomes
    cursos: cursos // let cursos

}