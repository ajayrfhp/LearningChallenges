using MethodChallenge;

Console.WriteLine("10 5 +-*/");
(double e, double f, double g, double h) = MiscMethods.OperateTuple(10.0, 5.0);
Console.WriteLine("{0} {1} {2} {3}", e, f, g, h);
MiscMethods.Operate(e, f, out e, out f, out g, out h);
Console.WriteLine("{0} {1} {2} {3}", e, f, g, h);
(e, f, g, h) = MiscMethods.OperateTuple(g, h);
Console.WriteLine("{0} {1} {2} {3}", e, f, g, h);
