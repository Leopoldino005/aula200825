decimal salario, irpfDevido;
Console.Write("Informe seu salário: ");
salario = decimal.Parse(Console.ReadLine());

if (salario <= 2428.8m)
    irpfDevido = 0;
else if (salario <= 2826.65m)
    irpfDevido = salario * 0.075m