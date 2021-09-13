using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{
    float ix = 11.61f;
    float iy = 5.29f;
    float ax1 = 16.19f;
    float ay1 = 4.75f;
    float ax2 = 17.32f;
    float ay2 = 2f;
    float cx = 22f;
    float cy = 1f;

    public float dotSpeed = 1f;
    public float circleSpeed = 1f;
    public float lineSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Background(0);

        //J
        Fill(255, 255, 255);
        Stroke(255, 255, 255);
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
        Circle(ix, iy, 0.2f);

            iy += dotSpeed * Time.deltaTime;

        if (iy > 6.615692f || iy < 5.29f)
        {
            dotSpeed *= -1;
            iy += dotSpeed * Time.deltaTime;

        }

        //c
        Line(12.35f, 4.75f, 13.9f, 4.75f);
        Line(12.35f, 4.75f, 12.35f, 2);
        Line(12.35f, 2, 13.9f, 2);

        //a
        Line(14.64f, 4.75f, 16.19f, 4.75f);
        Line(14.64f, 4.75f, 14.64f, 2);
        Line(14.64f, 2, 16.19f, 2);
        Line(16.19f, 4.75f, 16.19f, 2);
        Line(ax1, ay1, ax2, ay2);

        ax2 += lineSpeed * Time.deltaTime * 2;

        if (ax2 > 20f || ax2 < 17.32f)
        {
            lineSpeed *= -1;
            ax2 += lineSpeed * Time.deltaTime * 2;

        }

        //triangel
        Fill(226, 211, 54);
        Stroke(226, 211, 54);
        Triangle(20, 7.1f, 16.1f, 12, 23.61f, 11.74f);

        //fyrkant
        Fill(229, 99, 99, 255);
        Stroke(229, 99, 99, 255);
        Square(2.45f, 3.16f, 1.62f);

        //cirkel
        Fill(13, 123, 0, 255);
        Stroke(13, 123, 0, 255);
        Circle(cx, cy, 1);

        //Add 1 to x axis position
        cx += circleSpeed * Time.deltaTime * 8;
        cx = cx % Width;
    }

}

