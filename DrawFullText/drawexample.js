var isenabled_text = false;
var textString = "";
var textArr = new Array();
var wordwrap = 60;
var scale = 1.0;

API.onServerEventTrigger.connect(function (eventName, args) {
	if (eventName == "textfields") {
		isenabled_text = true;
		scale = args[0];
		wordwrap = args[1];
		textString = args[2];

		textArr = [];
	
		var tempString = "";
		var counter = 0;
		for (var i = 0; i < textString.length; i++) {
			if (!counter && textString[i] == ' ') {
				continue;
			}
			else {
				tempString += textString[i];
			}
			counter++;

			if (counter > wordwrap / (31 * scale) || (i + 1) >= textString.length) {
				if (textString[i] != ' ') {
					var cut = false;
					if ((i + 1) >= textString.length) {
						cut = true;
					}
					
					if (!cut) {
						for (var min = 1; min < 3; min++) {
							if (i - min >= 0 && textString[i - min] == ' ') {
								tempString = tempString.slice(0, -min);
								cut = true;

								i -= min;
								break;
							}
						}
					}

					if (!cut) {
						for (var max = 1; max < 3; max++) {
							if (i + max < textString.length && textString[i + max] == ' ') {
								tempString += textString.slice(i + 1, i + max);
								cut = true;

								i += max;
								break;
							}
						}
					}

					if (!cut) {
						tempString += "-";
					}
				}

				textArr.push(tempString);
				tempString = "";
				counter = 0;
			}
		}
	}
});

API.onUpdate.connect(function () {
	if (isenabled_text) {
		var res = API.getScreenResolutionMaintainRatio();

		API.drawRectangle(res.Width / 2, res.Height / 2, wordwrap, 500, 0, 0, 0, 200);

		for (var i = 0; i < textArr.length; i++) {
			API.drawText(textArr[i], res.Width / 2, res.Height / 2 + (i * scale * 100), scale, 255, 255, 255, 255, 0, 0, true, true, wordwrap + 20);
		}
	}
});
