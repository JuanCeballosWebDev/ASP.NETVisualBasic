// Generic function to test a number value
function checkNaN(labelName)
{ var hadError = false;
  
  if (window.event.srcElement.value == "")
  { alert(labelName + " (" + window.event.srcElement.id + ")");
    hadError = true;
  }
  else
  if (isNaN(window.event.srcElement.value ))
  { alert(labelName + " (" + window.event.srcElement.id + ")");
    hadError = true;
  }
  if (hadError)
    window.event.srcElement.focus();
  return !hadError;
}


