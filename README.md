To run the game please download the latest build in the release section, extract it and run the .exe

Overall most of the code in this project does not show my current knowledge of programming as while looking back through the code I am constantly thinking of better ways to approach it and to make the current code better.
One example of this is how I did the family system and how I was tracking the status of the family members.

    public GameObject selfOK;
    public GameObject selfBAD;
    public GameObject selfSICK;
    public GameObject wifeOK;
    public GameObject wifeBAD;
    public GameObject wifeSICK;
    public GameObject sonOK;
    public GameObject sonBAD;
    public GameObject sonSICK;

Instead of doing it like this I could use an array to simply go to the corresponding status.

However not all of the code in this project is bad and the one that stands out the most to me is the bullet pattern logic which defines the bullet pattern of the attack.

    private void FirePattern1Core()
        {
            float angleStep = (endAngle - startAngle) / bulletsAmount;
            float angle = startAngle;
    
            for (int i = 0; i < bulletsAmount + 1; i++)
            {
                float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
                float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);
    
                Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
                Vector2 bulDir = (bulMoveVector - transform.position).normalized;
    
                GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
                    bul.transform.position = transform.position;
                    bul.transform.rotation = transform.rotation;
                    bul.SetActive(true);
                    bul.GetComponent<EnemyBullet>().SetMoveDirection(bulDir);
    
                angle += angleStep;
            }
        }
        private void FirePattern1()
        {
            InvokeRepeating("FirePattern1Core", 0f, 2f);
            StartCoroutine(ChangeWait());
        }
