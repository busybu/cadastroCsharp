using System;

Aluno[] alunos = new Aluno[5];
Curso[] cursos = new Curso[5];
int qtCurso = 0;
int qtAluno = 0;
int resposta = -1; 

while(resposta != 0)
{   
        Console.WriteLine("-------Menu-------");
        Console.WriteLine("1 - Cadastrar Curso");
        Console.WriteLine("2 - Listar Cursos");
        Console.WriteLine("3 - Cadastrar Alunos");
        Console.WriteLine("4 - Dar Notas");
        Console.WriteLine("5 - Estatisticas");
        Console.WriteLine("0 - Sair");
        resposta = int.Parse(Console.ReadLine());
        switch (resposta)
        {
            case 1:
                Console.WriteLine("OPÇÃO: CADASTRAR CURSO");
                Console.WriteLine("Insira id do curso:");
                var curso = new Curso();
                curso.IdCurso = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira o nome do curso:");
                curso.NomeCurso = Console.ReadLine();
                Console.WriteLine("Insira a carga horária do curso:");
                curso.CargaHoraria = int.Parse(Console.ReadLine());
                cursos[qtCurso] = curso;
                qtCurso++;
                break;
            case 2:
                Console.WriteLine("OPÇÃO: LISTAR CURSO");
                foreach (var i in cursos)
                {
                    Console.WriteLine($"CURSO: {i.NomeCurso} - CÓDIGO: {i.IdCurso} - CARGA HORÁRIA: {i.CargaHoraria}");
                }
                break;
            case 3:
                Console.WriteLine("OPÇÃO: CADASTRAR ALUNO");
                Console.WriteLine("Insira o nome do aluno:");
                var aluno = new Aluno();
                aluno.NomeAluno = Console.ReadLine();
                Console.WriteLine("Insira a matrícula do aluno");
                aluno.Matricula = Console.ReadLine();  
                Console.WriteLine("Insira a ID do curso do aluno");
                aluno.IdCurso = int.Parse(Console.ReadLine()); 
                alunos[qtAluno] = aluno;
                qtAluno++;
                break;
            case 4:
                Console.WriteLine("OPÇÃO: DAR NOTAS");
                Console.WriteLine("Escolha o id do curso que deseja dar nota:");
                int idEscolha = int.Parse(Console.ReadLine()); 

                foreach (var atual in alunos)
                {
                    if(idEscolha == atual.IdCurso)
                    {   
                        Console.WriteLine($"Insira a nota para o aluno {atual.NomeAluno}:");
                        atual.Nota = int.Parse(Console.ReadLine()); 
                    }
                }
                break;
            case 5:
                Console.WriteLine("OPÇÃO: ESTATÍSTICA");
                Console.WriteLine("Escolha o id do curso que deseja verificar a estatística:");
                
        }
    }