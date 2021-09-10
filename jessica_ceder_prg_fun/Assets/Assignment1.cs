using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{

    public float x1;
    public float y1;
    public float x2;
    public float y2;
    public float x;
    public float y;
  

    // Start is called before the first frame update
    void Start()
    {
        Background(0);

        //J
        Line(4, 8, 4, 2);
        Line(4, 2, 1, 2);
        Line(1, 2, 1, 4.12f);

        //e
        Line(4.74f, 4, 6.29f, 4);
        Line(6.29f, 4, 6.29f, 4.75f);
        Line(4.74f, 4.75f, 6.29f, 4.75f);
        Line(4.74f, 4.75f, 4.74f, 2);
        Line(4.74f, 2, 6.29f, 2);

        //s
        Line(7.03f, 4, 8.58f, 4);
        Line(7.03f, 4.75f, 8.58f, 4.75f);
        Line(7.03f, 4, 7.03f, 4.75f);
        Line(8.58f, 4, 8.58f, 2);
        Line(7.03f, 2, 8.58f, 2);

        //s
        Line(9.32f, 4, 10.87f, 4);
        Line(9.32f, 4.75f, 10.87f, 4.75f);
        Line(9.32f, 4, 9.32f, 4.75f);
        Line(10.87f, 4, 10.87f, 2);
        Line(9.32f, 2, 10.87f, 2);

        //i
        Line(11.61f, 4.75f, 11.61f, 2);
        Circle(11.61f, 5.29f, 0.2f);

        //c
        Line(12.35f, 4.75f, 13.9f, 4.75f);
        Line(12.35f, 4.75f, 12.35f, 2);
        Line(12.35f, 2, 13.9f, 2);

        //a
        Line(14.64f, 4.75f, 16.19f, 4.75f);
        Line(14.64f, 4.75f, 14.64f, 2);
        Line(14.64f, 2, 16.19f, 2);
        Line(16.19f, 4.75f, 16.19f, 2);
        Line(16.19f, 4.75f, 17.32f, 2);

        //fyrkant
        Fill(229, 99, 99, 255);
        Stroke(229, 99, 99, 255);
        Square(19.37f, 7.54f, 1);

        //triangel
        Fill(13, 123, 0, 255);
        Stroke(13, 123, 0, 255);
        Circle(22, 3, 1);

    }

    // Update is called once per frame
    void Update()
    {

    }

}
