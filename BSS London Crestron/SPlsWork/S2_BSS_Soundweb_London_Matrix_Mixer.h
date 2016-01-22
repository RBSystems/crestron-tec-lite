#ifndef __S2_BSS_SOUNDWEB_LONDON_MATRIX_MIXER_H__
#define __S2_BSS_SOUNDWEB_LONDON_MATRIX_MIXER_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Matrix_Mixer_SUBSCRIBE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Matrix_Mixer_UNSUBSCRIBE$_DIG_INPUT 1

#define __S2_BSS_Soundweb_London_Matrix_Mixer_OUTPUT_MUTE$_DIG_INPUT 2
#define __S2_BSS_Soundweb_London_Matrix_Mixer_OUTPUT_MUTE$_ARRAY_LENGTH 48

/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_Matrix_Mixer_INPUT$_ANALOG_INPUT 0


#define __S2_BSS_Soundweb_London_Matrix_Mixer_RX$_BUFFER_INPUT 1
#define __S2_BSS_Soundweb_London_Matrix_Mixer_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Mixer, __RX$, __S2_BSS_Soundweb_London_Matrix_Mixer_RX$_BUFFER_MAX_LEN );

#define __S2_BSS_Soundweb_London_Matrix_Mixer_OUTPUT_GAIN$_ANALOG_INPUT 2
#define __S2_BSS_Soundweb_London_Matrix_Mixer_OUTPUT_GAIN$_ARRAY_LENGTH 48

/*
* DIGITAL_OUTPUT
*/

#define __S2_BSS_Soundweb_London_Matrix_Mixer_OUTPUT_MUTE_FB$_DIG_OUTPUT 0
#define __S2_BSS_Soundweb_London_Matrix_Mixer_OUTPUT_MUTE_FB$_ARRAY_LENGTH 48

/*
* ANALOG_OUTPUT
*/

#define __S2_BSS_Soundweb_London_Matrix_Mixer_TX$_STRING_OUTPUT 0

#define __S2_BSS_Soundweb_London_Matrix_Mixer_OUTPUT_GAIN_FB$_ANALOG_OUTPUT 1
#define __S2_BSS_Soundweb_London_Matrix_Mixer_OUTPUT_GAIN_FB$_ARRAY_LENGTH 48

/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
#define __S2_BSS_Soundweb_London_Matrix_Mixer_IMAXOUTPUT_INTEGER_PARAMETER 11
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/
#define __S2_BSS_Soundweb_London_Matrix_Mixer_OBJECTID$_STRING_PARAMETER 10
#define __S2_BSS_Soundweb_London_Matrix_Mixer_OBJECTID$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Mixer, __OBJECTID$, __S2_BSS_Soundweb_London_Matrix_Mixer_OBJECTID$_PARAM_MAX_LEN );


/*
* INTEGER
*/
CREATE_INTARRAY1D( S2_BSS_Soundweb_London_Matrix_Mixer, __VOLUMEOUTPUT, 48 );;
CREATE_INTARRAY1D( S2_BSS_Soundweb_London_Matrix_Mixer, __XOKGAIN, 48 );;


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_BSS_Soundweb_London_Matrix_Mixer_RETURNSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Mixer, __RETURNSTRING, __S2_BSS_Soundweb_London_Matrix_Mixer_RETURNSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Matrix_Mixer_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Mixer, __TEMPSTRING, __S2_BSS_Soundweb_London_Matrix_Mixer_TEMPSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Matrix_Mixer )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __OUTPUT_MUTE$ );
   DECLARE_IO_ARRAY( __OUTPUT_MUTE_FB$ );
   DECLARE_IO_ARRAY( __OUTPUT_GAIN$ );
   DECLARE_IO_ARRAY( __OUTPUT_GAIN_FB$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Mixer, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Mixer, __OBJECTID$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Matrix_Mixer )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Mixer, __RETURNSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Mixer, __TEMPSTRING );
   unsigned short __I;
   unsigned short __VOLUME;
   unsigned short __INPUT;
   unsigned short __RETURNI;
   unsigned short __SUBSCRIBE;
   unsigned short __XOK;
   unsigned short __XOKSUBSCRIBE;
   unsigned short __STATEVARONOFF;
   unsigned short __STATEVARGAIN;
   unsigned short __STATEVARSUB;
   unsigned short __STATEVARRECEIVE;
   unsigned short __X;
   DECLARE_INTARRAY( S2_BSS_Soundweb_London_Matrix_Mixer, __VOLUMEOUTPUT );
   DECLARE_INTARRAY( S2_BSS_Soundweb_London_Matrix_Mixer, __XOKGAIN );
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Matrix_Mixer, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_MATRIX_MIXER_H__

