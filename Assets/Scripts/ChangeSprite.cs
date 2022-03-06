using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer spriteRenderer;

	// Awake is good to get references from the same object or others in the scene
	private void Awake()
	{
		Debug.Log("I'm attached as a component of an object in the Scene!");
	}

	// Start is called before the first frame update
	void Start()
	{
        spriteRenderer = GetComponent<SpriteRenderer>();
		Debug.Log("You have just pressed PLAY BUTTON!");
	}

	// Update is called once per frame
	void Update()
	{
		/* Let's check some
		 * input from keyboard
		 * and change colors! */

		if (Input.GetKeyDown(KeyCode.Space)) {
			changeSprite();
		}
	}

    void changeSprite(){
        if (spriteRenderer.sprite == sprite1){
            spriteRenderer.sprite = sprite2;
        }else{
            spriteRenderer.sprite = sprite1;
        }
    }
}