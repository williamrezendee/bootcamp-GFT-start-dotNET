﻿using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System;
using System.Globalization;
using CsvHelper.Configuration;

var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "Produtos.csv");

var fi = new FileInfo(path);

if(!fi.Exists)
    throw new FileNotFoundException($"O arquivo {path} não existe!");

using var sr = new StreamReader(fi.FullName);
var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
using var csvReader = new CsvHelper.CsvReader(sr, csvConfig);

var registros = csvReader.GetRecords<dynamic>();

foreach (var registro in registros)
{
    Console.WriteLine($"nome:{registro.Produto}");
    Console.WriteLine($"marca:{registro.Marca}");
    Console.WriteLine($"preço:{registro.Preco}");
    Console.WriteLine("-----------------------------");
}