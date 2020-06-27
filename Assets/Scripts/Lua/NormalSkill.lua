NormalSkill = {}
local this = NormalSkill
local GameObject = UnityEngine.GameObject

local mainCharacter


function this.Use()
    mainCharacter = GameObject.Find('Samurai')
    local go = GameObject('go')
end