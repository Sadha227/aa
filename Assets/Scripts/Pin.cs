using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{

    [SerializeField] float speed = 20f;
    [SerializeField] Rigidbody2D rigidbody;
    private bool isPinned = false;

    void FixedUpdate()
    {
        if (isPinned == false)
        {
            rigidbody.MovePosition(rigidbody.position + Vector2.up * speed * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collisionObj)
    {
        if (collisionObj.tag == "Pin")
        {
            FindObjectOfType<Managar>().GameOver();
            Debug.Log("¯/_(ツ)_/¯");
        }
        else if (collisionObj.tag == "Rotator")
        {
            isPinned = true;
            transform.SetParent(collisionObj.transform);
            FindObjectOfType<ScoreText>().ChangeNumberOfPins();
            Managar managar = FindObjectOfType<Managar>();
            managar.AddPin();
            if (managar.GetTotalNumberOfPins() == managar.GetCurrentNumderOfPins()) { managar.LevelComplete(); }
        }
    }
}
