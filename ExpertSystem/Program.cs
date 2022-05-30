// See https://aka.ms/new-console-template for more information

using System;
using chen0040.ExpertSystem;



var inferenceEngine = new RuleInferenceEngine();

var rule = new Rule("Какой язык?");
rule.AddAntecedent(new IsClause("язык кандидата", "En"));
rule.setConsequent(new IsClause("язык", "английский"));
inferenceEngine.AddRule(rule);

rule = new Rule("Какой язык?");
rule.AddAntecedent(new IsClause("язык кандидата", "Fr"));
rule.setConsequent(new IsClause("язык", "французский"));
inferenceEngine.AddRule(rule);

rule = new Rule("Какой язык?");
rule.AddAntecedent(new IsClause("язык кандидата", "Ch"));
rule.setConsequent(new IsClause("язык", "китайский"));
inferenceEngine.AddRule(rule);

rule = new Rule("Образование магистратура, бакалавриат или среднее специальное?");
rule.AddAntecedent(new IsClause("уровень образования", "MD"));
rule.setConsequent(new IsClause("образование", "магистратура"));
inferenceEngine.AddRule(rule);

rule = new Rule("Образование магистратура или бакалавриат?");
rule.AddAntecedent(new IsClause("уровень образования", "BD"));
rule.setConsequent(new IsClause("образование", "бакалавриат"));
inferenceEngine.AddRule(rule);

rule = new Rule("Образование магистратура или бакалавриат?");
rule.AddAntecedent(new IsClause("уровень образования", "GSE"));
rule.setConsequent(new IsClause("образование", "среднее специальное"));
inferenceEngine.AddRule(rule);

rule = new Rule("Опыт работы больше 3-х лет?");
rule.AddAntecedent(new GreaterClause("опыт работы (в годах)", "-1"));
rule.AddAntecedent(new LessClause("опыт работы (в годах)", "3"));
rule.setConsequent(new IsClause("опыт работы", "нет"));
inferenceEngine.AddRule(rule);

rule = new Rule("Опыт работы больше 3-х лет?");
rule.AddAntecedent(new GreaterClause("опыт работы (в годах)", "2.9"));
rule.AddAntecedent(new LessClause("опыт работы (в годах)", "46"));
rule.setConsequent(new IsClause("опыт работы", "да"));
inferenceEngine.AddRule(rule);
//////////////////////////////////////////////////////////\
rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "английский"));
rule.AddAntecedent(new IsClause("образование", "магистратура"));
rule.setConsequent(new IsClause("кандидат подходит", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "английский"));
rule.AddAntecedent(new IsClause("образование", "бакалавриат"));
rule.setConsequent(new IsClause("кандидат подходит", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "английский"));
rule.AddAntecedent(new IsClause("образование", "среднее специальное"));
rule.AddAntecedent(new IsClause("опыт работы", "да"));
rule.setConsequent(new IsClause("кандидат подходит", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "английский"));
rule.AddAntecedent(new IsClause("образование", "среднее специальное"));
rule.AddAntecedent(new IsClause("опыт работы", "нет"));
rule.setConsequent(new IsClause("кандидат подходит", "нет"));
inferenceEngine.AddRule(rule);
///////////////////////////
rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "французский"));
rule.AddAntecedent(new IsClause("образование", "магистратура"));
rule.setConsequent(new IsClause("кандидат подходит", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "французский"));
rule.AddAntecedent(new IsClause("образование", "бакалавриат"));
rule.AddAntecedent(new IsClause("опыт работы", "да"));
rule.setConsequent(new IsClause("кандидат подходит", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "французский"));
rule.AddAntecedent(new IsClause("образование", "бакалавриат"));
rule.AddAntecedent(new IsClause("опыт работы", "нет"));
rule.setConsequent(new IsClause("кандидат подходит", "нет"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "французский"));
rule.AddAntecedent(new IsClause("образование", "среднее специальное"));
rule.setConsequent(new IsClause("кандидат подходит", "нет"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "китайский"));
rule.AddAntecedent(new IsClause("образование", "магистратура"));
rule.AddAntecedent(new IsClause("опыт работы", "да"));
rule.setConsequent(new IsClause("кандидат подходит", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "китайский"));
rule.AddAntecedent(new IsClause("образование", "бакалавриат"));
rule.setConsequent(new IsClause("кандидат подходит", "нет"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "китайский"));
rule.AddAntecedent(new IsClause("образование", "среднее специальное"));
rule.setConsequent(new IsClause("кандидат подходит", "нет"));
inferenceEngine.AddRule(rule);

rule = new Rule("Проверка кандидата");
rule.AddAntecedent(new IsClause("кандидат подходит", "да"));
rule.setConsequent(new IsClause("данные корректны", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Проверка кандидата");
rule.AddAntecedent(new IsClause("кандидат подходит", "нет"));
rule.setConsequent(new IsClause("данные корректны", "да"));
inferenceEngine.AddRule(rule);

Console.WriteLine("Введите следующие значения через пробел: \nязык значения- 'En', 'Fr', 'Ch', образование- 'MD', 'BD', 'GSE' и опыт работы (целое число): ");

string str = Console.ReadLine()!;

inferenceEngine.AddFact(new IsClause("язык кандидата", str.Split(" ")[0]));
inferenceEngine.AddFact(new IsClause("уровень образования", str.Split(" ")[1]));
inferenceEngine.AddFact(new IsClause("опыт работы (в годах)", str.Split(" ")[2]));
/*
inferenceEngine.AddFact(new IsClause("язык кандидата", "Fr"));
inferenceEngine.AddFact(new IsClause("уровень образования", "BD"));
inferenceEngine.AddFact(new IsClause("опыт работы (в годах)", "2"));
*/
inferenceEngine.Infer();
Console.WriteLine("Все факты:");
Console.WriteLine(inferenceEngine.Facts);

Console.WriteLine(" ");
var conclusion = inferenceEngine.Facts.IsFact(new IsClause("данные корректны", "да" ));
Console.WriteLine("Вывод:");
Console.WriteLine(conclusion ? "Кандидат определён." : "Логически кандидат не определён.");

