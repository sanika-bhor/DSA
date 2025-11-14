package com.tap.sanika.demo;

import java.util.Random;

public class Farm {
    private Climate[][] clm=new Climate[2][5];

    Random random=new Random();
    public Farm()
    {
        for(int i=0;i<2;i++)
        {
            for(int j=0;j<5;j++)
            {
                clm[i][j]=new Climate();
            }
        }
    }

    public void getCurrentClimate()
    {
        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 5; j++) {
                float temparature=15+random.nextFloat()*50;
                float humidity=30+random.nextFloat()*50;
                float intensity=200+random.nextFloat()*800;
                float co2=300+random.nextFloat()*400;
                float soilMoisture=20+random.nextFloat()*60;

                clm[i][j].setClimate(temparature, humidity, intensity, co2, soilMoisture);
            }
        }
    }


    public void display() {
        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 5; j++) {
                System.out.println("\nGreenhouse data of (Greenhouse: "+(i+1)+"."+(j+1)+")");
                clm[i][j].display();
            }
        }
    }
}
