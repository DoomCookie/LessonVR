using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitScore : MonoBehaviour
{
    [SerializeField]
    Transform centerPoint, bordrPoint;
    [SerializeField]
    int scoreBase = 100;
    [SerializeField]
    Text textScore;
    float length;

    private void Start()
    {
        length = centerPoint.TransformPoint(centerPoint.position - bordrPoint.position).magnitude;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            Vector3 contact = collision.GetContact(0).point;
            float lengthContact = (centerPoint.TransformPoint(contact) - centerPoint.TransformPoint(centerPoint.position)).magnitude / length;
            float koef = (float)Math.Round((double)lengthContact, 2);
            int score = Mathf.RoundToInt(scoreBase * (1 - koef));
            textScore.text = score.ToString();
            
        }
    }
}
