using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectScript : MonoBehaviour
{
    public ObjectTypes Type;
    public Rigidbody2D RB;
    public SpriteRenderer SR;
    public AudioSource AS;

    public void Setup(ObjectTypes type)
    {
        Type = type;
        SR.sprite = God.Library.GetSprite(type);
        AS.PlayOneShot(God.Library.GetSFx(type));
    }
    
    public void Jump(float mult=1)
    {
        RB.velocity = new Vector2(Random.Range(-5f, 5f), Random.Range(5f, 10f)) * mult;
    }

    void Update()
    {
        if (transform.position.y < -20)
        {
            Destroy(gameObject);
            God.GSM.AllFallers.Remove(this);
        }
    }
}
