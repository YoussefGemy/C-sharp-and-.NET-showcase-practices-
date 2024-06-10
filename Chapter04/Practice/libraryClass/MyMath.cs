namespace Mmath{
    public class MyMath{
        public string CalculatePrimeFactors(long n){
            string fact="";
            for(long i=2;i*i<=n;i++){
                while(n%i==0){
                    n/=i;
                    if(fact!=""){
                        fact+='*';
                    }
                    fact+=i.ToString();
                }
            }
            if(n>1){
                if(fact!=""){
                    fact+='*';
                }
                fact+=n.ToString();
            }
            return fact;
        }
    }
}