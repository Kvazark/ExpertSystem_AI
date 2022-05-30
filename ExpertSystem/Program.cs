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

rule = new Rule("Образование магистратура или бакалавриат?");
rule.AddAntecedent(new IsClause("образование", "MD"));
rule.setConsequent(new IsClause("высшее образование", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Образование магистратура или бакалавриат?");
rule.AddAntecedent(new IsClause("образование", "BD"));
rule.setConsequent(new IsClause("высшее образование", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Образование магистратура или бакалавриат?");
rule.AddAntecedent(new IsClause("образование", "GSE"));
rule.setConsequent(new IsClause("высшее образование", "нет"));
inferenceEngine.AddRule(rule);

rule = new Rule("Опыт работы больше 3-х лет?");
rule.AddAntecedent(new GreaterClause("опыт работы (в годах)", "0"));
rule.AddAntecedent(new LessClause("опыт работы (в годах)", "2"));
rule.setConsequent(new IsClause("опыт работы", "нет"));
inferenceEngine.AddRule(rule);

rule = new Rule("Опыт работы больше 3-х лет?");
rule.AddAntecedent(new GreaterClause("опыт работы (в годах)", "3"));
rule.AddAntecedent(new LessClause("опыт работы (в годах)", "45"));
rule.setConsequent(new IsClause("опыт работы", "да"));
inferenceEngine.AddRule(rule);
//////////////////////////////////////////////////////////\
rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "английский"));
rule.AddAntecedent(new IsClause("высшее образование", "да"));
rule.setConsequent(new IsClause("кандидат подходит", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "английский"));
rule.AddAntecedent(new IsClause("высшее образование", "нет"));
rule.AddAntecedent(new IsClause("опыт работы", "да"));
rule.setConsequent(new IsClause("кандидат подходит", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "английский"));
rule.AddAntecedent(new IsClause("высшее образование", "нет"));
rule.AddAntecedent(new IsClause("опыт работы", "нет"));
rule.setConsequent(new IsClause("кандидат подходит", "нет"));
inferenceEngine.AddRule(rule);
///////////////////////////
rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "французский"));
rule.AddAntecedent(new IsClause("высшее образование", "да"));
rule.AddAntecedent(new IsClause("опыт работы", "да"));
rule.setConsequent(new IsClause("кандидат подходит", "да"));
inferenceEngine.AddRule(rule);

rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "французский"));
rule.AddAntecedent(new IsClause("высшее образование", "нет"));
rule.setConsequent(new IsClause("кандидат подходит", "нет"));
inferenceEngine.AddRule(rule);


rule = new Rule("Брать на работу?");
rule.AddAntecedent(new IsClause("язык", "китайский"));
rule.setConsequent(new IsClause("кандидат подходит", "нет"));
inferenceEngine.AddRule(rule);


inferenceEngine.AddFact(new IsClause("язык кандидата", "Fr"));
inferenceEngine.AddFact(new IsClause("образование", "MD"));
inferenceEngine.AddFact(new IsClause("опыт работы (в годах)", "5"));

inferenceEngine.Infer();
Console.WriteLine("все факты:");
Console.WriteLine(inferenceEngine.Facts);

Console.WriteLine(" ");
var conclusion = inferenceEngine.Facts.IsFact(new IsClause("кандидат подходит", "да")); 
Console.WriteLine("Вывод:");
Console.WriteLine(conclusion ? "Кандидат подходит." : "Кандидат не подходит.");

