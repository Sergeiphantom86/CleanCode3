class Weapon
{
    private const int MinBulletsToShoot = 0;
    private const int BulletsPerShot = 1;

    private int _bullets;

    public bool CanShoot() => _bullets > MinBulletsToShoot;

    public void Shoot() => _bullets -= BulletsPerShot;
}
