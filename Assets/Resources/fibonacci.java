

public class fibonacci {

    public static void main (String[] ars){

        
        fibo(25);


    }

    public static int fibo(int num){

        int x=0;
        int y=1;
        int z=0;

        for (int i=0;i<num;i=i+1){
            z= x+y;
            x=y;
            y=z;
            System.out.print(z);
        }
        return z;
    }
}