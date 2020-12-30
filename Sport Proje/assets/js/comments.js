
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
		

function render2(data2) {
    
            var html2 = "<div class='commentBox'><div class='rightPanel'><span>" + data2.UserName + "</span><p>" + data2.body + "</p></div><div class='clear'></div></div>";
    
            $('#container2').append(html2);
			
        }
		
        $(document).ready(function() {
    
            var coment2 = [{
                "UserName": "",
                "body": ""
            }];
    
            for (var k = 0; k < coment2.length; k++) {
                render2(coment2[k]);
    
            }
    
            $('#addComent2').click(function() {
                var addObj2 = {
                    "name": $('#UserName').val(),
                    "body": $('#bodyText2').val()
                };
    
                coment2.push(addObj2);
                render2(addObj2);
                $('#UserName').val('');
                $('#bodyText2').val('');
            });
        });		

function render3(data3) {
    
            var html3 = "<div class='commentBox'><div class='rightPanel'><span>" + data3.UserName + "</span><p>" + data3.body + "</p></div><div class='clear'></div></div>";
    
            $('#container3').append(html3);
			
        }
		
        $(document).ready(function() {
    
            var coment3 = [{
                "UserName": "",
                "body": ""
            }];
    
            for (var l = 0; l < coment3.length; l++) {
                render3(coment3[l]);
    
            }
    
            $('#addComent3').click(function() {
                var addObj3 = {
                    "name": $('#UserName').val(),
                    "body": $('#bodyText3').val()
                };
    
                coment3.push(addObj3);
                render3(addObj3);
                $('#UserName').val('');
                $('#bodyText3').val('');
            });
        });		

function render4(data4) {
    
            var html4 = "<div class='commentBox'><div class='rightPanel'><span>" + data4.UserName + "</span><p>" + data4.body + "</p></div><div class='clear'></div></div>";
    
            $('#container4').append(html4);
			
        }
		
        $(document).ready(function() {
    
            var coment4 = [{
                "UserName": "",
                "body": ""
            }];
    
            for (var k = 0; k < coment4.length; k++) {
                render4(coment4[k]);
    
            }
    
            $('#addComent4').click(function() {
                var addObj4 = {
                    "name": $('#UserName').val(),
                    "body": $('#bodyText4').val()
                };
    
                coment4.push(addObj4);
                render4(addObj4);
                $('#UserName').val('');
                $('#bodyText4').val('');
            });
        });		

function render5(data5) {
    
            var html5 = "<div class='commentBox'><div class='rightPanel'><span>" + data5.UserName + "</span><p>" + data5.body + "</p></div><div class='clear'></div></div>";
    
            $('#container5').append(html5);
			
        }
		
        $(document).ready(function() {
    
            var coment5 = [{
                "UserName": "",
                "body": ""
            }];
    
            for (var k = 0; k < coment5.length; k++) {
                render5(coment5[k]);
    
            }
    
            $('#addComent5').click(function() {
                var addObj5 = {
                    "name": $('#UserName').val(),
                    "body": $('#bodyText5').val()
                };
    
                coment5.push(addObj5);
                render5(addObj5);
                $('#UserName').val('');
                $('#bodyText5').val('');
            });
        });		
		
function render6(data6) {
    
            var html6 = "<div class='commentBox'><div class='rightPanel'><span>" + data6.UserName + "</span><p>" + data6.body + "</p></div><div class='clear'></div></div>";
    
            $('#container6').append(html6);
			
        }
		
        $(document).ready(function() {
    
            var coment6 = [{
                "UserName": "",
                "body": ""
            }];
    
            for (var k = 0; k < coment6.length; k++) {
                render6(coment6[k]);
    
            }
    
            $('#addComent6').click(function() {
                var addObj6 = {
                    "name": $('#UserName').val(),
                    "body": $('#bodyText6').val()
                };
    
                coment6.push(addObj6);
                render6(addObj6);
                $('#UserName').val('');
                $('#bodyText6').val('');
            });
        });		

function render7(data7) {
    
            var html7 = "<div class='commentBox'><div class='rightPanel'><span>" + data7.UserName + "</span><p>" + data7.body + "</p></div><div class='clear'></div></div>";
    
            $('#container7').append(html7);
			
        }
		
        $(document).ready(function() {
    
            var coment7 = [{
                "UserName": "",
                "body": ""
            }];
    
            for (var k = 0; k < coment7.length; k++) {
                render7(coment7[k]);
    
            }
    
            $('#addComent7').click(function() {
                var addObj7 = {
                    "name": $('#UserName').val(),
                    "body": $('#bodyText7').val()
                };
    
                coment7.push(addObj7);
                render7(addObj7);
                $('#UserName').val('');
                $('#bodyText7').val('');
            });
        });		
function render8(data8) {
    
            var html8 = "<div class='commentBox'><div class='rightPanel'><span>" + data8.UserName + "</span><p>" + data8.body + "</p></div><div class='clear'></div></div>";
    
            $('#container8').append(html8);
			
        }
		
        $(document).ready(function() {
    
            var coment8 = [{
                "UserName": "",
                "body": ""
            }];
    
            for (var k = 0; k < coment8.length; k++) {
                render8(coment8[k]);
    
            }
    
            $('#addComent8').click(function() {
                var addObj8 = {
                    "name": $('#UserName').val(),
                    "body": $('#bodyText8').val()
                };
    
                coment8.push(addObj8);
                render8(addObj8);
                $('#UserName').val('');
                $('#bodyText8').val('');
            });
        });	
		
function render9(data9) {
    
            var html9 = "<div class='commentBox'><div class='rightPanel'><span>" + data9.UserName + "</span><p>" + data9.body + "</p></div><div class='clear'></div></div>";
    
            $('#container9').append(html9);
			
        }
		
        $(document).ready(function() {
    
            var coment9 = [{
                "UserName": "",
                "body": ""
            }];
    
            for (var k = 0; k < coment9.length; k++) {
                render9(coment9[k]);
    
            }
    
            $('#addComent9').click(function() {
                var addObj9 = {
                    "name": $('#UserName').val(),
                    "body": $('#bodyText9').val()
                };
    
                coment9.push(addObj9);
                render9(addObj9);
                $('#UserName').val('');
                $('#bodyText9').val('');
            });
        });		
		
function render10(data10) {
    
            var html10 = "<div class='commentBox'><div class='rightPanel'><span>" + data10.UserName + "</span><p>" + data10.body + "</p></div><div class='clear'></div></div>";
    
            $('#container10').append(html10);
			
        }
		
        $(document).ready(function() {
    
            var coment10 = [{
                "UserName": "",
                "body": ""
            }];
    
            for (var k = 0; k < coment10.length; k++) {
                render10(coment10[k]);
    
            }
    
            $('#addComent10').click(function() {
                var addObj10 = {
                    "name": $('#UserName').val(),
                    "body": $('#bodyText10').val()
                };
    
                coment10.push(addObj10);
                render10(addObj10);
                $('#UserName').val('');
                $('#bodyText10').val('');
            });
        });		

function myFunction() { alert("Mesajınız gönderildi!");}