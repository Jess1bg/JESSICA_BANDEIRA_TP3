using System;

class Ingresso
{
    public string nomeDoShow; // Esse atributo identifica qual evento ou show pertence o ingresso que esta sendo vendido. 
    public double preco; // Utilizado para definir o valor do ingresso, é importante para o cálculo de vendas e lucros.
    public int quantidadeDisponivel; // Exibe a qunatidade de ingressos disponiveis, com isso é possivel controlar o estoque para evitar vender mais ingressos do que o disponível.
}