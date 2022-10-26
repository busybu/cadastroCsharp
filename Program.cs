using System;

Aluno[] alunos = new Aluno[1000];
Curso[] cursos = new Curso[1000];
int resposta = -9999; 
int qtCurso = 0;
int qtAluno = 0;

while(resposta != 6)
{   
        Console.WriteLine("-------Menu-------");
        Console.WriteLine("1 - Cadastrar Curso");
        Console.WriteLine("2 - Listar Cursos");
        Console.WriteLine("3 - Cadastrar Alunos");
        Console.WriteLine("4 - Dar Notas");
        Console.WriteLine("5 - Estatisticas");
        Console.WriteLine("6 - Sair");
        resposta = int.Parse(Console.ReadLine());
        int reprovaram = 0;
        int passaram = 0; 
        double media = 0;
        double totalmedia =0;

        switch (resposta)
        {
            case 1:
                Console.WriteLine("OPÇÃO: CADASTRAR CURSO");
                var curso = new Curso();
                Console.WriteLine("Insira o NOME do curso:");
                curso.NomeCurso = Console.ReadLine();
                Console.WriteLine("Insira ID do curso:");
                curso.IdCurso = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira a CARGA HORÁRIA do curso:");
                curso.CargaHoraria = int.Parse(Console.ReadLine());
                cursos[qtCurso] = curso;
                qtCurso++;
                break;
            case 2:
                Console.WriteLine("OPÇÃO: LISTAR CURSO");
                foreach (var i in cursos)
                {
                    if (i == null)
                        break;
                    Console.WriteLine($"CURSO: {i.NomeCurso??="Vazio"} - CÓDIGO: {i.IdCurso} - CARGA HORÁRIA: {i.CargaHoraria}/h");
                }
                break;
            case 3:
                Console.WriteLine("OPÇÃO: CADASTRAR ALUNO");
                Console.WriteLine("Insira o NOME do aluno:");
                var aluno = new Aluno();
                aluno.NomeAluno = Console.ReadLine();
                Console.WriteLine("Insira a MATRÍCULA do aluno:");
                aluno.Matricula = Console.ReadLine();  
                Console.WriteLine("Insira a ID do CURSO do aluno:");
                aluno.IdCurso = int.Parse(Console.ReadLine()); 
                alunos[qtAluno] = aluno;
                qtAluno++;
                break;
            case 4:
                Console.WriteLine("OPÇÃO: DAR NOTAS");
                Console.WriteLine("Escolha o ID do CURSO que deseja dar nota:");
                int idEscolha = int.Parse(Console.ReadLine()); 

                foreach (var atual in alunos)
                {   
                    if (atual == null)
                        break;

                    else if(idEscolha == atual.IdCurso)
                    {   
                        Console.WriteLine($"Insira a NOTA para o aluno {atual.NomeAluno}:");
                        atual.Nota = int.Parse(Console.ReadLine()); 
                    }
                }
                break;
            case 5:
                Console.WriteLine("OPÇÃO: ESTATÍSTICA");
                Console.WriteLine("Escolha o ID do CURSO que deseja verificar a estatística:");
                int idEscolha2 = int.Parse(Console.ReadLine()); 
                int controle = 0;
                foreach (var atual in alunos)
                {   
                    if (atual == null)
                    {   
                        media = totalmedia / controle;
                        foreach (var i in cursos)
                        {
                            if (i == null)
                            break;
                            else if(i.IdCurso == idEscolha2)
                            Console.WriteLine($" CURSO: {i.NomeCurso} \r\n REPROVARAM: {reprovaram} \r\n PASSARAM: {passaram} \r\n MÉDIA: {media}");
                        }
                        break;
                    }
                    else if(idEscolha2 == atual.IdCurso)
                    {   
                        totalmedia += atual.Nota;
                        if(atual.Nota >= 6)
                        {
                            passaram++;
                        }
                        else
                        {
                            reprovaram++;
                        }
                        controle++;
                    }
                }
                break;
        }
    }