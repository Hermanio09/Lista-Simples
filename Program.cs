using Csharp.Models;
using System.Globalization;


Pessoa p1 = new Pessoa(nome: "Buta", sobrenome: "Lima");
Pessoa p2 = new Pessoa(nome: "Buta", sobrenome: "Guerra");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();




