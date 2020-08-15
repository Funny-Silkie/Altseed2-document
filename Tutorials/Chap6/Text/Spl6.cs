+       public EnemyBullet(MainNode mainNode, Vector2F position, Vector2F velocity) : base(mainNode, position, velocity)
-       public EnemyBullet(Vector2F position, Vector2F velocity) : base(position, velocity)
        {
            // �e�N�X�`����ǂݍ���
            Texture = Texture2D.LoadStrict("Resources/Bullet_Red.png");

            // ���S���W��ݒ�
            CenterPosition = ContentSize / 2;

+           // ���a��ݒ�
+           collider.Radius = Texture.Size.X / 2;
        }