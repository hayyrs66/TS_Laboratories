public static double[] CalcularCalificacionFinal(double[] evaluacion1, double[] evaluacion2, double[] evaluacion3)
{
    
    double promedio1 = (evaluacion1.Sum() + evaluacion2.Sum()) / (evaluacion1.Length + evaluacion2.Length);  
    double promedio2 = evaluacion3.Average();    
    double calificacionFinal = 0.6 * promedio1 + 0.4 * promedio2;    
    return new double[] { calificacionFinal };
}
