mergeInto(LibraryManager.library, {

  Hello: function () {
    console.log("game started..");
  },

  ShowAdFullScreen: function(){
    console.log("showedFullscreenAdv");

    //myGameInstance.SendMessage('MainMenuManagerScript', 'MuteSounds');
    
    ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
        console.log("Adv closed");

        //myGameInstance.SendMessage('MainMenuManagerScript', 'PlaySounds');
        },
        onError: function(error) {
          console.log("Adv ERROR");
        }
    }
  })
  },



});