using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinFactory: MonoBehaviour {
  public GameObject enemy;

  public float goblin_timer = 1;
  private static int enemy_count = 0;
  private float time_to_next_goblin;

  // Start is called before the first frame update
  void Start() {
    time_to_next_goblin = goblin_timer;
  }

  // Update is called once per frame
  void Update() {
    time_to_next_goblin -= Time.deltaTime;
    if (time_to_next_goblin <= 0) {
      time_to_next_goblin = goblin_timer + Random.Range(0, 4);
      Instantiate(enemy, transform.position, Quaternion.identity);
      enemy_count += 1;
    }
  }
}