// Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno tem anos e nota usando a concatenação e a interpolação de strings.
// j
// Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes .
// Console.WriteLine("O nome do aluno é " + nome + ".");
// Console.WriteLine("A idade do aluno " + nome + " é de " + idade + " anos.");
// Console.WriteLine("A nota do aluno é " + nota.");

// Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (x) double  ***Pois double é um tipo de ponto flutuante de precisão dupla, que pode armazenar valores maiores e mais precisos do que um float.
// ( ) long
// ( ) decimal 
 

// Em qual conversão numérica você precisaria realizar o casting (conversão forçada) ?
// ( ) int para long
// ( ) double para long
// (x) double para float  ***Quando você está convertendo de double para float, está essencialmente reduzindo a precisão do número, já que float não pode representar todos os valores que double pode. Portanto, o compilador precisa de uma indicação explícita de que você está ciente dessa perda de precisão e está realizando a conversão de forma intencional, o que é feito através do casting.
// ( ) decimal para float
// ( ) long para int
// ( ) double para decimal
 

// Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
// a concatenação e também a interpolação de strings

// Console.WriteLine("Digite a primeira letra : ");
// string letra1 = Console.ReadLine()!;
// Console.WriteLine("Digite a segunda letra : ");
// string letra2 = Console.ReadLine()!;
// Console.WriteLine("Digite a terceira letra : ");
// string letra3 = Console.ReadLine()!;

// Console.WriteLine($"As letras ao reverso são {letra3}, {letra2} e {letra1} !");

// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32; porque você está tentando atribuir um valor do tipo float (1.32) a uma variável do tipo long sem fazer uma conversão explícita.
// (V) var nome = “Maria”;
// (V) var nome = “Maria”; o tipo de dados da variável nome será inferido como string com base no valor "Maria". 
// (F) string resultado = 100.ToString(); Embora 100 seja um número, o método ToString() precisa ser chamado em um objeto. No entanto, neste caso, 100 é um valor inteiro primitivo e não um objeto
// (V) A sequência de escape \n inclui uma nova linha -  A sequência de escape "\n" é usada para representar uma nova linha
// (V) float f = 5.45; - Você pode atribuir diretamente um valor float a uma variável float.
// (V) decimal valor = (decimal) 10.99f; - A conversão explícita para decimal é necessária porque você está convertendo de float para decimal. 
// (F) var status = null; - Porque a inferência de tipo com var requer uma atribuição de valor na declaração, e null não é suficiente para inferir o tipo.
// (V) object o = 12.45m; - Um valor decimal pode ser atribuído a uma variável do tipo object implicitamente.
// (F) string titulo = true.ToString(); - Erro de compilação, pois você está tentando converter um booleano em uma string diretamente.
// (F) A sequencia \t inclui uma tabulação vertical \t" - Representa uma tabulação horizontal. Uma tabulação vertical seria representada por "\v".
 

// Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:

// Console.WriteLine("Digite o primeiro valor: ");
// double valor1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Digite o segundo valor: ");
// double valor2 = double.Parse(Console.ReadLine()!);

// double soma = valor1 + valor2;
// double subtracao = valor1 - valor2;
// double multiplicacao = valor1 * valor2;
// double exponenciacao = Math.Pow(valor1, valor2);
// double divisao = valor1 / valor2;
// double modulo = valor1 % valor2;

// Console.WriteLine($"A soma de {valor1} e {valor2} é {soma}");
// Console.WriteLine($"A subtração de {valor1} e {valor2} é {subtracao}");
// Console.WriteLine($"A multiplicação de {valor1} e {valor2} é {multiplicacao}");
// Console.WriteLine($"A exponenciação de {valor1} elevado a {valor2} é {exponenciacao}");
// Console.WriteLine($"A divisão de {valor1} e {valor2} é {divisao}");
// Console.WriteLine($"O módulo de {valor1} e {valor2} é {modulo}");

// Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
// inválido’: (use o operador condicional ternário)

// Console.WriteLine("Digite o nome do usuário : ");
// string? nomeUsuario = Console.ReadLine();
// Console.WriteLine("Digite a senha do usuário : ");
// int senhaUsuario = int.Parse(Console.ReadLine()!);

// string notificacao  = (nomeUsuario == "admin" && senhaUsuario == 123) ? "Login feito com sucesso !" : "Login Inválido";

// Console.WriteLine(notificacao);

// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
// console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

// Console.WriteLine("Digite o valor de x : ");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Digite o valor de y : ");
// int y = int.Parse(Console.ReadLine()!);

// string parOuImparX = (x % 2 == 0) ? "par" : "ímpar";
// string parOuImparY = (y % 2 == 0) ? "par" : "ímpar";

// Console.WriteLine($"O valor de x é {parOuImparX}.");
// Console.WriteLine($"O valor de y é {parOuImparY}.");