

var controller : CharacterController = GetComponent(CharacterController);
var FootSteps : AudioClip [];    // Таблица звуков.
private var StepTime : float = 0;        // Время шага.
var audioSource : AudioSource;
private var stepping : boolean = false; // Шагаем? По умолчанию нет.


function Update () {
if(controller.isGrounded){   // если персонаж на земле тогда...
if(!stepping){               // если персонаж не шагает тогда...

if (Input.GetButton("Vertical") || Input.GetButton("Horizontal")){   // нажата ли клавиши ходьбы.
StepTime = 0.5;              // назначаем время одного шага.
footfall();

} 

}
}
}

function footfall(){
	stepping = true;
	audioSource.PlayOneShot (FootSteps[Random.Range(0,FootSteps.length)]);
	yield WaitForSeconds (StepTime); 
	stepping = false;
}