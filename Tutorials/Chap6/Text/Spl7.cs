+       public PlayerBullet(MainNode mainNode, Vector2F position) : base(mainNode, position, new Vector2F(10f, 0.0f))
-       public PlayerBullet(Vector2F position) : base(position, new Vector2F(10f, 0.0f))
        {
            // �e�N�X�`����ǂݍ���
            Texture = Texture2D.LoadStrict("Resources/Bullet_Blue.png");

            // ���S���W��ݒ�
            CenterPosition = ContentSize / 2;

+           // ���a��ݒ�
+           collider.Radius = Texture.Size.X / 2;
        }