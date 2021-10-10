using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// the ball being launched.
public class Ball : MonoBehaviour
{
    // the round manager
    public RoundManager roundManager;

    // bounds for the screen - deletes ball ounce outside of these bounds
    Vector2 xBounds = new Vector2(-0.75F, 1.75F);
    Vector2 yBounds = new Vector2(-0.75F, 1.75F);

    // Start is called before the first frame update
    void Start()
    {
        // finds the round manager.
        if (roundManager == null)
            roundManager = FindObjectOfType<RoundManager>();
    }

    // checks if the ball is in the game bounds.
    public bool InBounds()
    {
        // checks area
        bool inX, inY;

        // checks if the ball is in the view bounds
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);

        // TODO: adjust y so that the ball falls back down.

        // check horizontal and vertical.
        inX = (viewPos.x >= xBounds.x && viewPos.x <= xBounds.y);
        inY = (viewPos.y >= yBounds.x && viewPos.y <= yBounds.y);

        // in x and y bounds
        return (inX && inY);
    }

    // Update is called once per frame
    void Update()
    {
        // ball out of bounds, so destroy it.
        if (!InBounds())
        {
            roundManager.Missed(); // say object has missed.
            Destroy(gameObject); // destroy object.
            // Destroy()
        }
            
    }
}
