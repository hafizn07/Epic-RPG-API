﻿using Epic_RPG_API.Dtos.Fight;

namespace Epic_RPG_API.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}
