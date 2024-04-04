using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    [SerializeField] TMP_Text pointTxt;

    private int points = 0;

	public void Start()
	{
		pointTxt.text = points.ToString();
	}

	public void addPoints(int points)
    {
        this.points += points;
        pointTxt.text = this.points.ToString();
    }
}
