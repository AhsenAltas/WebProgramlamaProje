
function render(data1) {
    
            var html = "<div class='commentBox'><div class='rightPanel'><span>" + data1.UserName + "</span><p>" + data1.body + "</p></div><div class='clear'></div></div>";
    
            $('#container1').append(html);
			
			
        }
    
        $(document).ready(function() {
    
            var coment = [{
                "UserName": "",
                "body": ""
            }];
    
            for (var i = 0; i < coment.length; i++) {
                render(coment[i]);
    
            }
    
            $('#addComent1').click(function() {
                var addObj = {
                    "name": $('#UserName').val(),
                    "body": $('#bodyText1').val()
                };
    
                coment.push(addObj);
                render(addObj);
                $('#UserName').val('');
                $('#bodyText1').val('');
            });
        });
		

function render(data2) {
    
            var html2 = "<div class='commentBox'><div class='rightPanel'><span>" + data2.UserName + "</span><p>" + data2.body + "</p></div><div class='clear'></div></div>";
    
            $('#container2').append(html2);
			
        }
		
        $(document).ready(function() {
    
            var coment2 = [{
                "UserName": "",
                "body": ""
            }];
    
            for (var k = 0; k < coment2.length; k++) {
                render(coment2[k]);
    
            }
    
            $('#addComent2').click(function() {
                var addObj2 = {
                    "name": $('#UserName').val(),
                    "body": $('#bodyText2').val()
                };
    
                coment2.push(addObj2);
                render(addObj2);
                $('#UserName').val('');
                $('#bodyText2').val('');
            });
        });		