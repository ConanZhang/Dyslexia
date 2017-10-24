using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gazeTrigger : MonoBehaviour {

	// Use this for initialization
	public TextMesh _text;
	public RaycastHit hit;
	int[] easy = {0, 2, 1, 5, 4, 3, 6, 7, 9, 8, 10, 12, 11, 13, 14, 15, 17, 16, 18, 19, 22, 20, 21, 23, 24, 25};
	int[] medium = { 0, 2, 3, 1, 5, 4, 6, 8, 10, 7, 9, 12, 11, 13, 14, 17, 15, 16, 18, 19, 21, 20, 23, 24, 22, 25 };
	int[] hard = { 0, 2, 3, 5, 1, 4, 6, 8, 10, 7, 9, 12, 11, 14, 13, 17, 15, 16, 19, 18, 22, 20, 23, 24, 21, 25 };
	char[] similar1 = { 'B', 'D', 'P' };
	char[] similar2 = { 'b', 'd', 'p', 'q' };
	char[] similar3 = { 'Q', 'O', 'C', 'U'};
	char[] similar4 = { 'c', 'o', 'u'};
	char[] similar5 = { 'E', 'F'};
	char[] similar6 = { 'T', 'I', 'L' };
	char[] similar7 = { 'V', 'A'};

	GameObject _whiteboard;
	TextMesh _textMesh;
	string original;
	string copy;
	string word ="";
	float x, y, z;
	float jumbleTime = 0.5f;
	float flipTime = 2f;
	string difficulty;
	bool makeRandom;

	void Start () {
		difficulty = "easy";
		_whiteboard = GameObject.FindWithTag ("board");
		_textMesh = _whiteboard.GetComponentInChildren<TextMesh>();
		original = _textMesh.text;
		makeRandom = true;
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		Time deltaTime;
		string s = "";
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		if (Time.time > jumbleTime) {
			if (makeRandom) {
				StartRandom ();
				jumbleTime += 1f;
			}if (hit.collider && hit.collider.tag == "board") {
					Debug.Log("STill hit");
				} else {
				makeRandom = true;
                Debug.Log("teest");
			}

		if (Physics.Raycast (transform.position, fwd, out hit)) {
			if (hit.collider && hit.collider.tag == "board") {
				Invoke ("CheckCollision", 3);
			}
		}
	}
	}

	void CheckCollision() {
		Vector3 fwd2 = transform.TransformDirection (Vector3.forward);
		if (Physics.Raycast (transform.position, fwd2, out hit)) {
			if (hit.collider && hit.collider.tag == "board") {
				makeRandom = false;
				_textMesh.text = original;
				Debug.Log ("After dealy");
			}
	}
	}
	void StartRandom()	{
		_text = _textMesh;
		Debug.Log (_text);
		string word = "";
		string randomText = "";
		string s = _text.text;
		s += " ";

			//Debug.Log (s);
			for (int i = 0; i < s.Length; i++) { 
				if (s [i] == ' ') {
					if (randomText.Length != 0)
						randomText += ' ';
					randomText += RandomText (word, difficulty);
					word = "";
				} else {
					word += s [i];
				}
			}
			randomText = SimilarWords (randomText);
		   _textMesh.text = randomText;		
	}

	string RandomText(string word, string difficulty)	{

		string random = "";

		switch (difficulty)
		{
		case "easy":
			for (int i = 0; i < word.Length; i++)
			{
				int temp = easy[i];
				while (temp > word.Length - 1) {
					temp = easy [i + 1];
					i++;
				}
				random += word[temp]; 
			}
			break;

		case "medium":
			for (int i = 0; i < word.Length; i++)
			{
				int temp = medium[i];
				while (temp > word.Length)
					temp--;
				random += word[temp];
			}
			break;

		case "hard":
			for (int i = 0; i < word.Length; i++)
			{
				int temp = hard[i];
				while (temp > word.Length)
					temp--;
				random += word[temp];
			}
			break;
		}
		return random;
	}

	Text Mirror(Text s)
	{
		//Debug.Log(s.rectTransform.localScale.x);
		s.rectTransform.localScale = new Vector3(s.rectTransform.localScale.x * -1, s.rectTransform.localScale.y, s.rectTransform.localScale.z);
		return s;
	}

	string SimilarWords(string word) {
		int randomNumber = 0;

		for (int i=0; i<word.Length; i++)
		{
			if (System.Array.IndexOf(similar1, word[i]) != -1)
			{
				randomNumber = Random.Range(0, similar1.Length - 1);
				word = word.Replace(word[i], similar1[randomNumber]);
			}
			else if (System.Array.IndexOf(similar2, word[i]) != -1)
			{
				randomNumber = Random.Range(0, similar2.Length - 1);
				word = word.Replace(word[i], similar2[randomNumber]);
			}
			else if (System.Array.IndexOf(similar3, word[i]) != -1)
			{
				randomNumber = Random.Range(0, similar3.Length - 1);
				word = word.Replace(word[i], similar3[randomNumber]);
			}
			else if (System.Array.IndexOf(similar4, word[i]) != -1)
			{
				randomNumber = Random.Range(0, similar4.Length - 1);
				word = word.Replace(word[i], similar4[randomNumber]);
			}
			else if (System.Array.IndexOf(similar5, word[i]) != -1)
			{
				randomNumber = Random.Range(0, similar5.Length - 1);
				word = word.Replace(word[i], similar5[randomNumber]);
			}
			else if (System.Array.IndexOf(similar6, word[i]) != -1)
			{
				randomNumber = Random.Range(0, similar6.Length - 1);
				word = word.Replace(word[i], similar6[randomNumber]);
			}
			else if (System.Array.IndexOf(similar7, word[i]) != -1)
			{
				randomNumber = Random.Range(0, similar7.Length - 1);
				word = word.Replace(word[i], similar7[randomNumber]);
			}
		}
		return word;
	}

}


