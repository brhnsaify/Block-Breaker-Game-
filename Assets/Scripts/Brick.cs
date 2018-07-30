using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int MaxHits;
	public Sprite[] hitSprites;
	public static int breakableCount = 0;

	public AudioClip boing;

	private int timesHit;
	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		timesHit=0;
		breakableCount++;
		//print(breakableCount);
		levelManager= GameObject.FindObjectOfType<LevelManager>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		//GetComponent<AudioSource>().Play();
		AudioSource.PlayClipAtPoint(boing, transform.position);
		timesHit++;
		if(timesHit >= MaxHits){
		breakableCount--;
		levelManager.BrickDestroyed();
		//print("dec"+breakableCount);
		Destroy(gameObject);
		}else{
			LoadSprites();
		}
		//SimulateWin();
	}

	void LoadSprites(){
		int spriteIndex = timesHit-1;
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}

	/*//TODO test meathod remove
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}*/
}
