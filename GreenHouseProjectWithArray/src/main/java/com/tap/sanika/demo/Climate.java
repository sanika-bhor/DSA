package com.tap.sanika.demo;
public class Climate {
    private float temparature;
    private float humidity;
    private float intensity;
    private float co2;
    private float soilMoisture;
    private int row=2;
    private int columns=5;

    public Climate()
    {
        this.temparature=0;
        this.humidity=0;
        this.intensity=0;
        this.co2=0;
        this.soilMoisture=0;
    }

    public void setClimate(float temparature, float humidity,float intensity,float co2,float soilMoisture)
    {
        this.temparature=temparature;
        this.humidity=humidity;
        this.intensity=intensity;
        this.co2=co2;
        this.soilMoisture=soilMoisture;
    }

    public void display()
    {
        System.out.println("Temparature: "+this.temparature+" c");
        System.out.println("Humidity: "+this.humidity+" %");
        System.out.println("Intensity: "+this.intensity+" lux");
        System.out.println("CO2: "+this.co2+" ppm");
        System.out.println("Soil Moisture: "+this.soilMoisture+" %");
    }
}
