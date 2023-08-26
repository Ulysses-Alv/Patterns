using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DestroyOnGround : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ground", StringComparison.InvariantCulture))
        {

            // TODO
            // Add points
            StartCoroutine(MarkInactive(2.0f));

        }
    }


    IEnumerator MarkInactive( float time)
    {

        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);

    }

}
