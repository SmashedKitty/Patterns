// See https://aka.ms/new-console-template for more information
using FctorySample15._03.Factory;

var factoryRu = new FacilityRu();
var carRu = factoryRu.BuildCar();
Console.WriteLine();

var factoryTr = new FacilityTr();
var carTr = factoryTr.BuildCar();