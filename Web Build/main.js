{ // Setup
var EnableMods = document.getElementById("EnableMods");
var SilenceSounds = document.getElementById("SilenceSounds");
var Task_CanAttackMouse = document.getElementById("Task_CanAttackMouse");
var AttackRandomly = document.getElementById("AttackRandomly");
var UseCustomColors = document.getElementById("UseCustomColors");
var GooseDefaultWhite = document.getElementById("GooseDefaultWhite");
var GooseDefaultOrange = document.getElementById("GooseDefaultOrange");
var GooseDefaultOutline = document.getElementById("GooseDefaultOutline");
var MaxWanderingTimeSeconds = document.getElementById("MaxWanderingTimeSeconds");
var MinWanderingTimeSeconds = document.getElementById("MinWanderingTimeSeconds");
var FirstWanderTimeSeconds = document.getElementById("FirstWanderTimeSeconds");
var copy = document.getElementById("copy");
var success = document.getElementById("success");
var down = document.getElementById("download");

var apply = document.getElementById("apply");
var config = document.getElementById("config-text");
var config_text = "Version_DoNotEdit=1\nEnableMods=False\nSilenceSounds=False\nTask_CanAttackMouse=True\nAttackRandomly=False\nUseCustomColors=True\nGooseDefaultWhite=#ffffff\nGooseDefaultOrange=#ffa500\nGooseDefaultOutline=#d3d3d3\nMinWanderingTimeSeconds=20\nMaxWanderingTimeSeconds=40\nFirstWanderTimeSeconds=20";
config.value = config_text;
Task_CanAttackMouse.checked = true;
UseCustomColors.checked = true; 
} // Setup End

// Function to capitalize first letter of a word
function capitalizeFirstLetter(str) {
    return str.charAt(0).toUpperCase() + str.slice(1);
  }

// when apply click
apply.addEventListener("click", function() {
    config_text = `Version_DoNotEdit=1\nEnableMods=${capitalizeFirstLetter( EnableMods.checked.toString() )}\nSilenceSounds=${capitalizeFirstLetter(SilenceSounds.checked.toString())}\nTask_CanAttackMouse=${capitalizeFirstLetter(Task_CanAttackMouse.checked.toString())}\nAttackRandomly=${capitalizeFirstLetter(AttackRandomly.checked.toString())}\nUseCustomColors=${capitalizeFirstLetter(UseCustomColors.checked.toString())}\nGooseDefaultWhite=${GooseDefaultWhite.value}\nGooseDefaultOrange=${GooseDefaultOrange.value}\nGooseDefaultOutline=${GooseDefaultOutline.value}\nMinWanderingTimeSeconds=${MinWanderingTimeSeconds.value}\nMaxWanderingTimeSeconds=${MaxWanderingTimeSeconds.value}\nFirstWanderTimeSeconds=${FirstWanderTimeSeconds.value}`;
    config.value = config_text;
    config.focus();
});
// Spaghettiest code i've ever seen
MaxWanderingTimeSeconds.addEventListener("change", function() {
    if (MaxWanderingTimeSeconds.value < MinWanderingTimeSeconds.value)
        MaxWanderingTimeSeconds.value = MinWanderingTimeSeconds.value;
        
    if (MaxWanderingTimeSeconds.value < 1) {
        MaxWanderingTimeSeconds.value = 0;
    } else if (MaxWanderingTimeSeconds.value > 99999){
        MaxWanderingTimeSeconds.value = 99999;
    }
});
MinWanderingTimeSeconds.addEventListener("change", function() {
    if (MinWanderingTimeSeconds.value > MaxWanderingTimeSeconds.value)
        MinWanderingTimeSeconds.value = MaxWanderingTimeSeconds.value;
    
        if (MinWanderingTimeSeconds.value < 1) {
            MinWanderingTimeSeconds.value = 0;
        } else if (MinWanderingTimeSeconds.value > 99999){
            MinWanderingTimeSeconds.value = 99999;
        }
} );
FirstWanderTimeSeconds.addEventListener("change", function() {
    if (FirstWanderTimeSeconds.value < 1) {
        FirstWanderTimeSeconds.value = 0;
    } else if (FirstWanderTimeSeconds.value > 99999){
        FirstWanderTimeSeconds.value = 99999;
    }
} );

copy.addEventListener("click", function() {
    config.select();
    config.setSelectionRange(0, 99999);
    document.execCommand("copy");
});
// Copy text

down.addEventListener("click", function(){download(config_text, "config.ini", "plain/text")});
// Function to download data to a file
function download(data, filename, type) {
    var file = new Blob([data], {type: type});
    if (window.navigator.msSaveOrOpenBlob) // IE10+
        window.navigator.msSaveOrOpenBlob(file, filename);
    else { // Others
        var a = document.createElement("a"),
                url = URL.createObjectURL(file);
        a.href = url;
        a.download = filename;
        document.body.appendChild(a);
        a.click();
        setTimeout(function() {
            document.body.removeChild(a);
            window.URL.revokeObjectURL(url);  
        }, 0); 
    }
} // https://stackoverflow.com/questions/13405129/javascript-create-and-save-file/53864791