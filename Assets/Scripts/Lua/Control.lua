Control = {}
local this = Control
require('Music')
local GameObject = UnityEngine.GameObject
local Input = UnityEngine.Input
local AudioSource = UnityEngine.AudioSource
local Rigidbody = UnityEngine.Rigidbody
local Color = UnityEngine.Color
local Sphere
local rigi
local force

function this.Start()
    Sphere = GameObject.Find('Sphere')
    Sphere : GetComponent('Renderer').material.color = Color(1, 0.1, 1)
    Sphere : AddComponent(typeof(AudioSource))
    coroutine.start(Music.PlaySound)
    Sphere : AddComponent(typeof(Rigidbody))
    rigi = Sphere : GetComponent('Rigidbody')
    force = 5
end

function this.Update()
    local h = Input.GetAxis('Horizontal')
    local v = Input.GetAxis('Vertical')
    rigi : AddForce(Vector3(h, 0, v) * force)
end 