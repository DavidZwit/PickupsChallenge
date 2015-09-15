using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float m_score = 0;
    private float speed = 3;
    private bool rotate = false;

    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
        this.transform.position += Vector3.right * Time.deltaTime * speed;

        if (rotate == true)
        {
            this.transform.Rotate(0f,0f, 3f);
        }
    }

    public float AddScore
    {
        get { return m_score; }
        set { m_score += value; }
    }
    public float MoveSpeed
    {
        get { return speed; }
        set { speed = value; }
    }
    public bool Rotatation
    {
        get { return rotate; }
        set { rotate = !rotate; }
    }
}
