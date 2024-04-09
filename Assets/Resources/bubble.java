public class bubble {

    public static void main(String []ars){

        double[] blk={85,65,2,10,800,47,33,1,0,86};
        printarray(blk);

        System.out.println("");
        System.out.println("");

        bubsort(blk);
        printarray(blk);


    }


    public static double[] bubsort(double[] ar){
        double median;
        
        for (int i=0;i<ar.length-1;i=i+1){

            for (int j=0;j<ar.length-1;j=j+1){

                if(ar[j]>ar[j+1]){

                    median=ar[j+1];
                    ar[j+1]=ar[j];
                    ar[j]=median;
                }
            }
        }

        return ar;
    }

    public static void printarray(double[] ar){
        for (int i=0;i<ar.length;i=i+1){
            System.out.print(ar[i]);
        }

    }

}