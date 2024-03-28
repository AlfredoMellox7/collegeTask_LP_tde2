// Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno tem anos e nota usando a concatenação e a interpolação de strings.
// string nome = "Paulo";
// int idade = 17;
// double nota = 7.5;

// Console.WriteLine("O aluno " + nome + " tem " + idade + " de idade e a sua nota é " + nota + " .");
// Console.WriteLine($"O aluno {nome} tem {idade} de idade e a sua nota é {nota} .");

//Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes .
// Console.WriteLine($"O aluno {nome}\ntem {idade} anos de idade\ne sua nota é {nota}.");

// Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (x) double  ***Pois double é um tipo de ponto flutuante de precisão dupla, que pode armazenar valores maiores e mais precisos do que um float.
// ( ) long
// (x) decimal 
 

// Em qual conversão numérica você precisaria realizar o casting (conversão forçada) ?
// ( ) int para long
// (x) double para long
// (x) double para float  ***Quando você está convertendo de double para float, está essencialmente reduzindo a precisão do número, já que float não pode representar todos os valores que double pode. Portanto, o compilador precisa de uma indicação explícita de que você está ciente dessa perda de precisão e está realizando a conversão de forma intencional, o que é feito através do casting.
// (x) decimal para float
// (x) long para int
// (x) double para decimal
 

// Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
// a concatenação e também a interpolação de strings

// char letra1, letra2, letra3;
// Console.WriteLine("Informe uma letra : ");
// letra1 = Convert.ToChar(Console.ReadLine());
// Console.WriteLine("Informe uuma segunda letra : ");
// letra2 = Convert.ToChar(Console.ReadLine());
// Console.WriteLine("Informe uuma terceira letra : ");
// letra3 = Convert.ToChar(Console.ReadLine());

// Console.WriteLine(letra3 + " " +  letra2 + " " + letra1);
// Console.WriteLine($"As letras aescolhidas ao contrário ficarão : {letra3}{letra2}{letra1}.");

// Console.WriteLine($"As letras ao reverso são {letra3}, {letra2} e {letra1} !");

// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32; Porque você está tentando atribuir um valor do tipo float (1.32) a uma variável do tipo long sem fazer uma conversão explícita.
// (V) var nome = “Maria”; O tipo de dados da variável nome será inferido como string com base no valor "Maria". 
// (V) string resultado = 100.ToString(); Embora 100 seja um número, o método ToString() precisa ser chamado em um objeto. No entanto, neste caso, 100 é um valor inteiro primitivo e não um objeto
// (V) A sequência de escape \n inclui uma nova linha -  A sequência de escape "\n" é usada para representar uma nova linha.
// (F) float f = 5.45; - Faltou uum f no final 5.45f.
// (V) decimal valor = (decimal) 10.99f; - A conversão explícita para decimal é necessária porque você está convertendo de float para decimal. De trás para frente o calculo.
// (F) var status = null; - Porque a inferência de tipo com var requer uma atribuição de valor na declaração, e null não é suficiente para inferir o tipo.
// (V) object o = 12.45m; - Um valor decimal pode ser atribuído a uma variável do tipo object implicitamente.
// (V) string titulo = true.ToString(); - Foi convertido explicitamente .
// (F) A sequencia \t inclui uma tabulação vertical \t" - Representa uma tabulação horizontal. Uma tabulação vertical seria representada por "\v".
 
// Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:

// Console.WriteLine("Digite o primeiro valor: ");
// double valor1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Digite o segundo valor: ");
// double valor2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Digite o terceiro valor: ");
// double valor3 = Convert.ToDouble(Console.ReadLine());

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
// Console.WriteLine($"A raíz quadrada é {valor1} = {Math.Sqrt(valor1)} .");

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

Console.WriteLine("Informe o valor de X : ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de Y : ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(x%2 == 0? "X é par ." : "X é ímpar .");
Console.WriteLine(y%2 == 0? "Y é par ." : "Y é ímpar .");