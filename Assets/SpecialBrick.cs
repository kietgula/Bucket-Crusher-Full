using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBrick : MonoBehaviour
{
    bool isTouched;
    // Start is called before the first frame update
    void Start()
    {
        isTouched = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="The Saw" && isTouched==false)
        {
            colapse();

            foreach (GameObject brick in GameEnvironment.Singleton.Bricks)
            {
                if (brick.transform.position.y > this.transform.position.y && Mathf.Abs(brick.transform.position.x - this.transform.position.x) <= 0.5)
                    brick.GetComponent<SpecialBrick>().colapse();
            }

        }
    }

    public void colapse()
    {
        if (isTouched == false)
        {
            Rigidbody rd = this.gameObject.AddComponent<Rigidbody>();
            rd.useGravity = true;
            isTouched = true;
        }
    }


}
