
 int addition(int m, int n)
 {
    if (m == 0) return (n * (n + 1)) / 2;            
    else if (n == 0) return (m * (m + 1)) / 2;       
    else if (m == n) return m;                       
    else if (m < n) return n + addition(m, n - 1); 
    else return n + addition(m, n + 1);            
}
int M = 4;
int N = 8;
Console.Write($"M = {M}, N = {N} -> = {addition(M, N)}.");

        
    
