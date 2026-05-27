<?xml version="1.0" encoding="utf-8" standalone="yes"?>
<results>
  <modules>
    <module id="5CF813922CE78C428E6341B4BAF1BE35543E26B0" name="HealthAppTests.dll" path="HealthAppTests.dll" block_coverage="97.35" line_coverage="91.39" blocks_covered="1029" blocks_not_covered="28" lines_covered="616" lines_partially_covered="58" lines_not_covered="0">
      <functions>
        <function id="8284" token="0x6000003" name="AppointmentServiceTests()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="5" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="19" end_line="19" start_column="9" end_column="41" covered="yes" />
            <range source_id="0" start_line="20" end_line="20" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="21" end_line="21" start_column="13" end_column="56" covered="yes" />
            <range source_id="0" start_line="22" end_line="22" start_column="13" end_column="61" covered="yes" />
            <range source_id="0" start_line="23" end_line="23" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="8327" token="0x6000004" name="GetPatient()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="25" end_line="25" start_column="48" end_column="71" covered="yes" />
          </ranges>
        </function>
        <function id="8342" token="0x6000005" name="GetDoctor(bool)" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="4" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="28" end_line="28" start_column="13" end_column="54" covered="yes" />
          </ranges>
        </function>
        <function id="8368" token="0x6000006" name="GetAppointment()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="13" blocks_not_covered="0" lines_covered="10" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="31" end_line="31" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="32" end_line="39" start_column="13" end_column="15" covered="yes" />
            <range source_id="0" start_line="40" end_line="40" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="8472" token="0x6000007" name="BookAppointment_ShouldWork()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="17" blocks_not_covered="0" lines_covered="10" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="44" end_line="44" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="45" end_line="45" start_column="13" end_column="75" covered="yes" />
            <range source_id="0" start_line="47" end_line="52" start_column="13" end_column="15" covered="yes" />
            <range source_id="0" start_line="54" end_line="54" start_column="13" end_column="36" covered="yes" />
            <range source_id="0" start_line="55" end_line="55" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="8633" token="0x6000008" name="BookAppointment_ShouldThrowPastDate()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="8" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="59" end_line="59" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="60" end_line="65" start_column="13" end_column="42" covered="yes" />
            <range source_id="0" start_line="66" end_line="66" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="8654" token="0x6000009" name="BookAppointment_ShouldThrowDoctorUnavailable()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="8" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="70" end_line="70" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="71" end_line="76" start_column="13" end_column="42" covered="yes" />
            <range source_id="0" start_line="77" end_line="77" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="8675" token="0x600000a" name="BookAppointment_ShouldThrowInvalidSlot()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="8" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="81" end_line="81" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="82" end_line="87" start_column="13" end_column="33" covered="yes" />
            <range source_id="0" start_line="88" end_line="88" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="8696" token="0x600000b" name="BookAppointment_ShouldThrowPatientConflict()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="10" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="92" end_line="92" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="93" end_line="93" start_column="13" end_column="41" covered="yes" />
            <range source_id="0" start_line="95" end_line="95" start_column="13" end_column="82" covered="yes" />
            <range source_id="0" start_line="97" end_line="102" start_column="13" end_column="37" covered="yes" />
            <range source_id="0" start_line="103" end_line="103" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="8852" token="0x600000c" name="BookAppointment_ShouldThrow_WhenSameSlotBookedByPatient()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="24" blocks_not_covered="0" lines_covered="20" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="108" end_line="108" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="109" end_line="109" start_column="13" end_column="40" covered="yes" />
            <range source_id="0" start_line="110" end_line="110" start_column="13" end_column="38" covered="yes" />
            <range source_id="0" start_line="112" end_line="119" start_column="13" end_column="15" covered="yes" />
            <range source_id="0" start_line="121" end_line="122" start_column="13" end_column="74" covered="yes" />
            <range source_id="0" start_line="124" end_line="129" start_column="13" end_column="52" covered="yes" />
            <range source_id="0" start_line="130" end_line="130" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9112" token="0x600000d" name="BookAppointment_ShouldThrowSlotConflict()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="10" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="135" end_line="135" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="136" end_line="136" start_column="13" end_column="41" covered="yes" />
            <range source_id="0" start_line="138" end_line="138" start_column="13" end_column="82" covered="yes" />
            <range source_id="0" start_line="140" end_line="145" start_column="13" end_column="37" covered="yes" />
            <range source_id="0" start_line="146" end_line="146" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9268" token="0x600000e" name="Cancel_ShouldWork()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="150" end_line="150" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="151" end_line="151" start_column="13" end_column="41" covered="yes" />
            <range source_id="0" start_line="153" end_line="153" start_column="13" end_column="58" covered="yes" />
            <range source_id="0" start_line="155" end_line="155" start_column="13" end_column="51" covered="yes" />
            <range source_id="0" start_line="157" end_line="157" start_column="13" end_column="68" covered="yes" />
            <range source_id="0" start_line="158" end_line="158" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9424" token="0x600000f" name="Cancel_ShouldThrowNotFound()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="162" end_line="162" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="163" end_line="163" start_column="13" end_column="72" covered="yes" />
            <range source_id="0" start_line="165" end_line="166" start_column="13" end_column="53" covered="yes" />
            <range source_id="0" start_line="167" end_line="167" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9564" token="0x6000010" name="Cancel_ShouldThrowAlreadyCancelled()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="171" end_line="171" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="172" end_line="172" start_column="13" end_column="41" covered="yes" />
            <range source_id="0" start_line="173" end_line="173" start_column="13" end_column="30" covered="yes" />
            <range source_id="0" start_line="175" end_line="175" start_column="13" end_column="58" covered="yes" />
            <range source_id="0" start_line="177" end_line="178" start_column="13" end_column="53" covered="yes" />
            <range source_id="0" start_line="179" end_line="179" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9720" token="0x6000011" name="Cancel_ShouldThrowCompleted()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="183" end_line="183" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="184" end_line="184" start_column="13" end_column="41" covered="yes" />
            <range source_id="0" start_line="185" end_line="185" start_column="13" end_column="29" covered="yes" />
            <range source_id="0" start_line="187" end_line="187" start_column="13" end_column="58" covered="yes" />
            <range source_id="0" start_line="189" end_line="190" start_column="13" end_column="53" covered="yes" />
            <range source_id="0" start_line="191" end_line="191" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9872" token="0x6000012" name="GetAppointmentsByPatient_ShouldReturn()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="195" end_line="195" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="196" end_line="196" start_column="13" end_column="41" covered="yes" />
            <range source_id="0" start_line="198" end_line="198" start_column="13" end_column="82" covered="yes" />
            <range source_id="0" start_line="200" end_line="200" start_column="13" end_column="63" covered="yes" />
            <range source_id="0" start_line="202" end_line="202" start_column="13" end_column="35" covered="yes" />
            <range source_id="0" start_line="203" end_line="203" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10004" token="0x6000013" name="GetUpcomingAppointments_ShouldThrowPastDate()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="208" end_line="208" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="209" end_line="213" start_column="13" end_column="38" covered="yes" />
            <range source_id="0" start_line="214" end_line="214" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10025" token="0x6000014" name="GetUpcomingAppointments_ShouldThrowInvalidRange()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="218" end_line="218" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="219" end_line="223" start_column="13" end_column="38" covered="yes" />
            <range source_id="0" start_line="224" end_line="224" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10048" token="0x6000015" name="GetUpcomingAppointments_ShouldReturn()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="18" blocks_not_covered="0" lines_covered="10" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="229" end_line="229" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="230" end_line="230" start_column="13" end_column="41" covered="yes" />
            <range source_id="0" start_line="231" end_line="231" start_column="13" end_column="28" covered="yes" />
            <range source_id="0" start_line="233" end_line="233" start_column="13" end_column="82" covered="yes" />
            <range source_id="0" start_line="235" end_line="238" start_column="13" end_column="44" covered="yes" />
            <range source_id="0" start_line="240" end_line="240" start_column="13" end_column="35" covered="yes" />
            <range source_id="0" start_line="241" end_line="241" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10216" token="0x6000016" name="GetPendingAppointments_ShouldReturn()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="245" end_line="245" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="246" end_line="246" start_column="13" end_column="41" covered="yes" />
            <range source_id="0" start_line="248" end_line="248" start_column="13" end_column="82" covered="yes" />
            <range source_id="0" start_line="250" end_line="250" start_column="13" end_column="69" covered="yes" />
            <range source_id="0" start_line="252" end_line="252" start_column="13" end_column="35" covered="yes" />
            <range source_id="0" start_line="253" end_line="253" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10348" token="0x6000017" name="CheckAvailability_ShouldReturnSlots()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="257" end_line="257" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="258" end_line="258" start_column="13" end_column="75" covered="yes" />
            <range source_id="0" start_line="260" end_line="262" start_column="13" end_column="44" covered="yes" />
            <range source_id="0" start_line="264" end_line="264" start_column="13" end_column="37" covered="yes" />
            <range source_id="0" start_line="265" end_line="265" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10488" token="0x6000018" name="CheckAvailability_ShouldThrowPastDate()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="269" end_line="269" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="270" end_line="271" start_column="13" end_column="82" covered="yes" />
            <range source_id="0" start_line="272" end_line="272" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10509" token="0x6000019" name="CheckAvailability_ShouldThrowRange()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="277" end_line="277" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="278" end_line="279" start_column="13" end_column="82" covered="yes" />
            <range source_id="0" start_line="280" end_line="280" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10532" token="0x600001a" name="Confirm_ShouldWork()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="284" end_line="284" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="285" end_line="285" start_column="13" end_column="41" covered="yes" />
            <range source_id="0" start_line="287" end_line="287" start_column="13" end_column="58" covered="yes" />
            <range source_id="0" start_line="289" end_line="289" start_column="13" end_column="44" covered="yes" />
            <range source_id="0" start_line="291" end_line="291" start_column="13" end_column="68" covered="yes" />
            <range source_id="0" start_line="292" end_line="292" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10684" token="0x600001b" name="GetAppointmentById_ShouldReturnAppointment_WhenFound()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="16" blocks_not_covered="0" lines_covered="8" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="297" end_line="297" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="298" end_line="298" start_column="13" end_column="69" covered="yes" />
            <range source_id="0" start_line="300" end_line="301" start_column="13" end_column="44" covered="yes" />
            <range source_id="0" start_line="303" end_line="303" start_column="13" end_column="57" covered="yes" />
            <range source_id="0" start_line="305" end_line="305" start_column="13" end_column="36" covered="yes" />
            <range source_id="0" start_line="306" end_line="306" start_column="13" end_column="51" covered="yes" />
            <range source_id="0" start_line="307" end_line="307" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10852" token="0x600001c" name="GetAppointmentById_ShouldThrowException_WhenNotFound()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="311" end_line="311" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="312" end_line="313" start_column="13" end_column="51" covered="yes" />
            <range source_id="0" start_line="315" end_line="316" start_column="13" end_column="49" covered="yes" />
            <range source_id="0" start_line="317" end_line="317" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10992" token="0x600001d" name="GetAllAppointments_ShouldReturnAppointments()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="20" blocks_not_covered="0" lines_covered="12" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="321" end_line="321" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="322" end_line="326" start_column="13" end_column="11" covered="yes" />
            <range source_id="0" start_line="328" end_line="329" start_column="13" end_column="37" covered="yes" />
            <range source_id="0" start_line="331" end_line="331" start_column="13" end_column="56" covered="yes" />
            <range source_id="0" start_line="333" end_line="333" start_column="13" end_column="36" covered="yes" />
            <range source_id="0" start_line="334" end_line="334" start_column="13" end_column="43" covered="yes" />
            <range source_id="0" start_line="335" end_line="335" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11164" token="0x600001e" name="GetAllAppointments_ShouldThrowException_WhenNull()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="11" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="339" end_line="339" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="340" end_line="341" start_column="13" end_column="56" covered="yes" />
            <range source_id="0" start_line="344" end_line="345" start_column="13" end_column="48" covered="yes" />
            <range source_id="0" start_line="346" end_line="346" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11276" token="0x600001f" name="GetAllAppointments_ShouldThrowException_WhenEmpty()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="350" end_line="350" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="352" end_line="353" start_column="13" end_column="56" covered="yes" />
            <range source_id="0" start_line="354" end_line="355" start_column="13" end_column="48" covered="yes" />
            <range source_id="0" start_line="356" end_line="356" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11392" token="0x6000020" name="CheckDoctorAvailability_ShouldThrowSlotAlreadyOverException()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="24" blocks_not_covered="0" lines_covered="15" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="359" end_line="359" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="360" end_line="360" start_column="13" end_column="30" covered="yes" />
            <range source_id="0" start_line="361" end_line="361" start_column="13" end_column="50" covered="yes" />
            <range source_id="0" start_line="362" end_line="367" start_column="13" end_column="25" covered="yes" />
            <range source_id="0" start_line="368" end_line="368" start_column="13" end_column="20" covered="yes" />
            <range source_id="0" start_line="368" end_line="368" start_column="49" end_column="61" covered="yes" />
            <range source_id="0" start_line="368" end_line="368" start_column="22" end_column="45" covered="yes" />
            <range source_id="0" start_line="369" end_line="369" start_column="17" end_column="39" covered="yes" />
            <range source_id="0" start_line="368" end_line="368" start_column="46" end_column="48" covered="yes" />
            <range source_id="0" start_line="371" end_line="371" start_column="13" end_column="64" covered="yes" />
            <range source_id="0" start_line="373" end_line="374" start_column="13" end_column="67" covered="yes" />
            <range source_id="0" start_line="375" end_line="375" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11652" token="0x6000021" name="GetPendingAppointments_ShouldThrow_WhenNoAppointments()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="378" end_line="378" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="379" end_line="380" start_column="13" end_column="52" covered="yes" />
            <range source_id="0" start_line="382" end_line="383" start_column="13" end_column="61" covered="yes" />
            <range source_id="0" start_line="384" end_line="384" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11768" token="0x6000022" name="ConfirmAppointment_ShouldThrowAlreadyCancelled()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="15" blocks_not_covered="0" lines_covered="10" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="387" end_line="387" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="388" end_line="391" start_column="13" end_column="15" covered="yes" />
            <range source_id="0" start_line="392" end_line="392" start_column="13" end_column="33" covered="yes" />
            <range source_id="0" start_line="394" end_line="394" start_column="13" end_column="58" covered="yes" />
            <range source_id="0" start_line="396" end_line="397" start_column="13" end_column="49" covered="yes" />
            <range source_id="0" start_line="398" end_line="398" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11932" token="0x6000023" name="ConfirmAppointment_ShouldThrowAlreadyCompleted()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="15" blocks_not_covered="0" lines_covered="10" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="401" end_line="401" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="402" end_line="405" start_column="13" end_column="15" covered="yes" />
            <range source_id="0" start_line="406" end_line="406" start_column="13" end_column="29" covered="yes" />
            <range source_id="0" start_line="408" end_line="408" start_column="13" end_column="58" covered="yes" />
            <range source_id="0" start_line="410" end_line="411" start_column="13" end_column="49" covered="yes" />
            <range source_id="0" start_line="412" end_line="412" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12092" token="0x6000024" name="&lt;BookAppointment_ShouldThrowPastDate&gt;b__7_0()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="85.71" line_coverage="0.00" blocks_covered="6" blocks_not_covered="1" lines_covered="0" lines_partially_covered="5" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="61" end_line="65" start_column="17" end_column="40" covered="partial" />
          </ranges>
        </function>
        <function id="12160" token="0x6000025" name="&lt;BookAppointment_ShouldThrowDoctorUnavailable&gt;b__8_0()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="85.71" line_coverage="0.00" blocks_covered="6" blocks_not_covered="1" lines_covered="0" lines_partially_covered="5" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="72" end_line="76" start_column="17" end_column="40" covered="partial" />
          </ranges>
        </function>
        <function id="12228" token="0x6000026" name="&lt;BookAppointment_ShouldThrowInvalidSlot&gt;b__9_0()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="83.33" line_coverage="0.00" blocks_covered="5" blocks_not_covered="1" lines_covered="0" lines_partially_covered="5" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="83" end_line="87" start_column="17" end_column="31" covered="partial" />
          </ranges>
        </function>
        <function id="12290" token="0x6000027" name="&lt;Cancel_ShouldThrowNotFound&gt;b__14_1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="166" end_line="166" start_column="17" end_column="51" covered="partial" />
          </ranges>
        </function>
        <function id="12310" token="0x6000028" name="&lt;Cancel_ShouldThrowAlreadyCancelled&gt;b__15_1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="178" end_line="178" start_column="17" end_column="51" covered="partial" />
          </ranges>
        </function>
        <function id="12330" token="0x6000029" name="&lt;Cancel_ShouldThrowCompleted&gt;b__16_1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="190" end_line="190" start_column="17" end_column="51" covered="partial" />
          </ranges>
        </function>
        <function id="12352" token="0x600002a" name="&lt;GetUpcomingAppointments_ShouldThrowPastDate&gt;b__18_0()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="80.00" line_coverage="0.00" blocks_covered="4" blocks_not_covered="1" lines_covered="0" lines_partially_covered="4" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="210" end_line="213" start_column="17" end_column="36" covered="partial" />
          </ranges>
        </function>
        <function id="12404" token="0x600002b" name="&lt;GetUpcomingAppointments_ShouldThrowInvalidRange&gt;b__19_0()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="80.00" line_coverage="0.00" blocks_covered="4" blocks_not_covered="1" lines_covered="0" lines_partially_covered="4" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="220" end_line="223" start_column="17" end_column="36" covered="partial" />
          </ranges>
        </function>
        <function id="12456" token="0x600002c" name="&lt;CheckAvailability_ShouldThrowPastDate&gt;b__23_0()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="75.00" line_coverage="0.00" blocks_covered="3" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="271" end_line="271" start_column="17" end_column="80" covered="partial" />
          </ranges>
        </function>
        <function id="12504" token="0x600002d" name="&lt;CheckAvailability_ShouldThrowRange&gt;b__24_0()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="75.00" line_coverage="0.00" blocks_covered="3" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="279" end_line="279" start_column="17" end_column="80" covered="partial" />
          </ranges>
        </function>
        <function id="12551" token="0x600002e" name="&lt;GetAppointmentById_ShouldThrowException_WhenNotFound&gt;b__27_1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="316" end_line="316" start_column="17" end_column="47" covered="partial" />
          </ranges>
        </function>
        <function id="12565" token="0x600002f" name="&lt;GetAllAppointments_ShouldThrowException_WhenNull&gt;b__29_1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="345" end_line="345" start_column="17" end_column="46" covered="partial" />
          </ranges>
        </function>
        <function id="12578" token="0x6000030" name="&lt;GetAllAppointments_ShouldThrowException_WhenEmpty&gt;b__30_1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="355" end_line="355" start_column="17" end_column="46" covered="partial" />
          </ranges>
        </function>
        <function id="12591" token="0x6000031" name="&lt;GetPendingAppointments_ShouldThrow_WhenNoAppointments&gt;b__32_1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="383" end_line="383" start_column="17" end_column="59" covered="partial" />
          </ranges>
        </function>
        <function id="12605" token="0x6000032" name="&lt;ConfirmAppointment_ShouldThrowAlreadyCancelled&gt;b__33_1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="397" end_line="397" start_column="17" end_column="47" covered="partial" />
          </ranges>
        </function>
        <function id="12620" token="0x6000033" name="&lt;ConfirmAppointment_ShouldThrowAlreadyCompleted&gt;b__34_1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="411" end_line="411" start_column="17" end_column="47" covered="partial" />
          </ranges>
        </function>
        <function id="12635" token="0x6000034" name="DoctorServiceTests()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="5" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="19" end_line="19" start_column="9" end_column="36" covered="yes" />
            <range source_id="1" start_line="20" end_line="20" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="21" end_line="21" start_column="13" end_column="55" covered="yes" />
            <range source_id="1" start_line="22" end_line="22" start_column="13" end_column="60" covered="yes" />
            <range source_id="1" start_line="23" end_line="23" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12678" token="0x6000035" name="GetDoctor()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="6" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="26" end_line="32" start_column="46" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12724" token="0x6000036" name="AddDoctor_ShouldAssignId()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="29" blocks_not_covered="0" lines_covered="8" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="36" end_line="36" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="37" end_line="37" start_column="13" end_column="74" covered="yes" />
            <range source_id="1" start_line="39" end_line="39" start_column="13" end_column="38" covered="yes" />
            <range source_id="1" start_line="41" end_line="41" start_column="13" end_column="40" covered="yes" />
            <range source_id="1" start_line="43" end_line="43" start_column="13" end_column="46" covered="yes" />
            <range source_id="1" start_line="44" end_line="44" start_column="13" end_column="42" covered="yes" />
            <range source_id="1" start_line="45" end_line="45" start_column="13" end_column="62" covered="yes" />
            <range source_id="1" start_line="46" end_line="46" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="13028" token="0x6000037" name="GetAllDoctors_ShouldReturnDoctors()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="50" end_line="50" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="51" end_line="52" start_column="13" end_column="65" covered="yes" />
            <range source_id="1" start_line="54" end_line="54" start_column="13" end_column="51" covered="yes" />
            <range source_id="1" start_line="56" end_line="56" start_column="13" end_column="35" covered="yes" />
            <range source_id="1" start_line="57" end_line="57" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="13160" token="0x6000038" name="GetAllDoctors_ShouldThrowException_WhenEmpty()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="61" end_line="61" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="62" end_line="63" start_column="13" end_column="51" covered="yes" />
            <range source_id="1" start_line="65" end_line="66" start_column="13" end_column="43" covered="yes" />
            <range source_id="1" start_line="67" end_line="67" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="13276" token="0x6000039" name="GetDoctorById_ShouldReturnDoctor()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="13" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="71" end_line="71" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="72" end_line="73" start_column="13" end_column="44" covered="yes" />
            <range source_id="1" start_line="75" end_line="75" start_column="13" end_column="52" covered="yes" />
            <range source_id="1" start_line="77" end_line="77" start_column="13" end_column="36" covered="yes" />
            <range source_id="1" start_line="78" end_line="78" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="13420" token="0x600003a" name="GetDoctorById_ShouldThrowException_WhenNotFound()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="82" end_line="82" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="83" end_line="84" start_column="13" end_column="46" covered="yes" />
            <range source_id="1" start_line="86" end_line="87" start_column="13" end_column="44" covered="yes" />
            <range source_id="1" start_line="88" end_line="88" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="13560" token="0x600003b" name="Search_ShouldReturnDoctors()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="92" end_line="92" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="93" end_line="94" start_column="13" end_column="65" covered="yes" />
            <range source_id="1" start_line="96" end_line="96" start_column="13" end_column="91" covered="yes" />
            <range source_id="1" start_line="98" end_line="98" start_column="13" end_column="35" covered="yes" />
            <range source_id="1" start_line="99" end_line="99" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="13692" token="0x600003c" name="Search_ShouldThrowException_WhenNoMatch()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="103" end_line="103" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="104" end_line="105" start_column="13" end_column="51" covered="yes" />
            <range source_id="1" start_line="107" end_line="108" start_column="13" end_column="83" covered="yes" />
            <range source_id="1" start_line="109" end_line="109" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="13808" token="0x600003d" name="ChangeStatus_ShouldReturnMessage()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="15" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="113" end_line="113" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="114" end_line="114" start_column="13" end_column="38" covered="yes" />
            <range source_id="1" start_line="116" end_line="117" start_column="13" end_column="39" covered="yes" />
            <range source_id="1" start_line="119" end_line="119" start_column="13" end_column="64" covered="yes" />
            <range source_id="1" start_line="121" end_line="121" start_column="13" end_column="49" covered="yes" />
            <range source_id="1" start_line="122" end_line="122" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="13984" token="0x600003e" name="ChangeStatus_ShouldThrowException_WhenNotFound()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="126" end_line="126" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="127" end_line="128" start_column="13" end_column="46" covered="yes" />
            <range source_id="1" start_line="130" end_line="130" start_column="13" end_column="96" covered="yes" />
            <range source_id="1" start_line="131" end_line="131" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="14145" token="0x600003f" name="&lt;GetAllDoctors_ShouldThrowException_WhenEmpty&gt;b__6_1()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="66" end_line="66" start_column="17" end_column="41" covered="partial" />
          </ranges>
        </function>
        <function id="14158" token="0x6000040" name="&lt;GetDoctorById_ShouldThrowException_WhenNotFound&gt;b__8_1()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="87" end_line="87" start_column="17" end_column="42" covered="partial" />
          </ranges>
        </function>
        <function id="14172" token="0x6000041" name="&lt;Search_ShouldThrowException_WhenNoMatch&gt;b__10_1()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="108" end_line="108" start_column="17" end_column="81" covered="partial" />
          </ranges>
        </function>
        <function id="14186" token="0x6000042" name="&lt;ChangeStatus_ShouldThrowException_WhenNotFound&gt;b__12_1()" namespace="HealthAppTests.Service_Layer" type_name="DoctorServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="130" end_line="130" start_column="58" end_column="94" covered="partial" />
          </ranges>
        </function>
        <function id="14201" token="0x6000043" name="HealthRecordServiceTests()" namespace="HealthAppTests.Service_Layer" type_name="HealthRecordServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="5" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="19" end_line="19" start_column="9" end_column="42" covered="yes" />
            <range source_id="2" start_line="20" end_line="20" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="21" end_line="21" start_column="13" end_column="61" covered="yes" />
            <range source_id="2" start_line="22" end_line="22" start_column="13" end_column="66" covered="yes" />
            <range source_id="2" start_line="23" end_line="23" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="14244" token="0x6000044" name="GetRecord(int, int)" namespace="HealthAppTests.Service_Layer" type_name="HealthRecordServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="9" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="26" end_line="26" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="27" end_line="33" start_column="13" end_column="15" covered="yes" />
            <range source_id="2" start_line="34" end_line="34" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="14328" token="0x6000045" name="AddRecord_ShouldAssignIdAndAdd()" namespace="HealthAppTests.Service_Layer" type_name="HealthRecordServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="27" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="38" end_line="38" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="39" end_line="39" start_column="13" end_column="80" covered="yes" />
            <range source_id="2" start_line="41" end_line="41" start_column="13" end_column="38" covered="yes" />
            <range source_id="2" start_line="43" end_line="43" start_column="13" end_column="40" covered="yes" />
            <range source_id="2" start_line="45" end_line="45" start_column="13" end_column="46" covered="yes" />
            <range source_id="2" start_line="46" end_line="46" start_column="13" end_column="62" covered="yes" />
            <range source_id="2" start_line="47" end_line="47" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="14620" token="0x6000046" name="GetPatientRecords_ShouldReturnMatchingRecords()" namespace="HealthAppTests.Service_Layer" type_name="HealthRecordServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="19" blocks_not_covered="0" lines_covered="11" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="51" end_line="51" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="52" end_line="57" start_column="13" end_column="11" covered="yes" />
            <range source_id="2" start_line="59" end_line="59" start_column="13" end_column="63" covered="yes" />
            <range source_id="2" start_line="61" end_line="61" start_column="13" end_column="56" covered="yes" />
            <range source_id="2" start_line="63" end_line="63" start_column="13" end_column="43" covered="yes" />
            <range source_id="2" start_line="64" end_line="64" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="14788" token="0x6000047" name="GetPatientRecords_ShouldThrowException_WhenNoMatch()" namespace="HealthAppTests.Service_Layer" type_name="HealthRecordServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="68" end_line="68" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="69" end_line="70" start_column="13" end_column="57" covered="yes" />
            <range source_id="2" start_line="72" end_line="73" start_column="13" end_column="48" covered="yes" />
            <range source_id="2" start_line="74" end_line="74" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="14904" token="0x6000048" name="GetHealthRecordsByDoctor_ShouldReturnFilteredRecords()" namespace="HealthAppTests.Service_Layer" type_name="HealthRecordServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="19" blocks_not_covered="0" lines_covered="11" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="78" end_line="78" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="79" end_line="84" start_column="13" end_column="11" covered="yes" />
            <range source_id="2" start_line="86" end_line="86" start_column="13" end_column="63" covered="yes" />
            <range source_id="2" start_line="88" end_line="88" start_column="13" end_column="66" covered="yes" />
            <range source_id="2" start_line="90" end_line="90" start_column="13" end_column="43" covered="yes" />
            <range source_id="2" start_line="91" end_line="91" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="15076" token="0x6000049" name="GetHealthRecordsByDoctor_ShouldBeSortedDescending()" namespace="HealthAppTests.Service_Layer" type_name="HealthRecordServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="39" blocks_not_covered="0" lines_covered="14" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="95" end_line="95" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="96" end_line="96" start_column="13" end_column="38" covered="yes" />
            <range source_id="2" start_line="97" end_line="97" start_column="13" end_column="41" covered="yes" />
            <range source_id="2" start_line="99" end_line="99" start_column="13" end_column="38" covered="yes" />
            <range source_id="2" start_line="100" end_line="100" start_column="13" end_column="53" covered="yes" />
            <range source_id="2" start_line="102" end_line="102" start_column="13" end_column="38" covered="yes" />
            <range source_id="2" start_line="103" end_line="103" start_column="13" end_column="53" covered="yes" />
            <range source_id="2" start_line="105" end_line="106" start_column="13" end_column="70" covered="yes" />
            <range source_id="2" start_line="108" end_line="108" start_column="13" end_column="66" covered="yes" />
            <range source_id="2" start_line="110" end_line="110" start_column="13" end_column="43" covered="yes" />
            <range source_id="2" start_line="112" end_line="112" start_column="13" end_column="69" covered="yes" />
            <range source_id="2" start_line="113" end_line="113" start_column="13" end_column="69" covered="yes" />
            <range source_id="2" start_line="114" end_line="114" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="15396" token="0x600004a" name="GetHealthRecordsByDoctor_ShouldThrowException_WhenNoRecordsFound()" namespace="HealthAppTests.Service_Layer" type_name="HealthRecordServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="119" end_line="119" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="120" end_line="121" start_column="13" end_column="57" covered="yes" />
            <range source_id="2" start_line="123" end_line="124" start_column="13" end_column="58" covered="yes" />
            <range source_id="2" start_line="125" end_line="125" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="15512" token="0x600004b" name="&lt;GetPatientRecords_ShouldThrowException_WhenNoMatch&gt;b__6_1()" namespace="HealthAppTests.Service_Layer" type_name="HealthRecordServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="73" end_line="73" start_column="17" end_column="46" covered="partial" />
          </ranges>
        </function>
        <function id="15526" token="0x600004c" name="&lt;GetHealthRecordsByDoctor_ShouldThrowException_WhenNoRecordsFound&gt;b__9_1()" namespace="HealthAppTests.Service_Layer" type_name="HealthRecordServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="124" end_line="124" start_column="17" end_column="56" covered="partial" />
          </ranges>
        </function>
        <function id="15541" token="0x600004d" name="PatientServiceTests()" namespace="HealthAppTests.Service_Layer" type_name="PatientServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="5" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="20" end_line="20" start_column="9" end_column="37" covered="yes" />
            <range source_id="3" start_line="21" end_line="21" start_column="9" end_column="10" covered="yes" />
            <range source_id="3" start_line="22" end_line="22" start_column="13" end_column="56" covered="yes" />
            <range source_id="3" start_line="23" end_line="23" start_column="13" end_column="61" covered="yes" />
            <range source_id="3" start_line="24" end_line="24" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="15584" token="0x600004e" name="Register_ShouldAssignId_WhenEmpty()" namespace="HealthAppTests.Service_Layer" type_name="PatientServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="28" end_line="28" start_column="9" end_column="10" covered="yes" />
            <range source_id="3" start_line="29" end_line="30" start_column="13" end_column="52" covered="yes" />
            <range source_id="3" start_line="32" end_line="32" start_column="13" end_column="41" covered="yes" />
            <range source_id="3" start_line="34" end_line="34" start_column="13" end_column="47" covered="yes" />
            <range source_id="3" start_line="36" end_line="36" start_column="13" end_column="48" covered="yes" />
            <range source_id="3" start_line="37" end_line="37" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="15716" token="0x600004f" name="Register_ShouldAssignNextId()" namespace="HealthAppTests.Service_Layer" type_name="PatientServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="20" blocks_not_covered="0" lines_covered="12" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="42" end_line="42" start_column="9" end_column="10" covered="yes" />
            <range source_id="3" start_line="43" end_line="47" start_column="13" end_column="11" covered="yes" />
            <range source_id="3" start_line="49" end_line="50" start_column="13" end_column="37" covered="yes" />
            <range source_id="3" start_line="52" end_line="52" start_column="13" end_column="41" covered="yes" />
            <range source_id="3" start_line="54" end_line="54" start_column="13" end_column="47" covered="yes" />
            <range source_id="3" start_line="56" end_line="56" start_column="13" end_column="48" covered="yes" />
            <range source_id="3" start_line="57" end_line="57" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="15888" token="0x6000050" name="GetById_ShouldReturnPatient()" namespace="HealthAppTests.Service_Layer" type_name="PatientServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="61" end_line="61" start_column="9" end_column="10" covered="yes" />
            <range source_id="3" start_line="62" end_line="62" start_column="13" end_column="57" covered="yes" />
            <range source_id="3" start_line="64" end_line="65" start_column="13" end_column="40" covered="yes" />
            <range source_id="3" start_line="67" end_line="67" start_column="13" end_column="53" covered="yes" />
            <range source_id="3" start_line="69" end_line="69" start_column="13" end_column="36" covered="yes" />
            <range source_id="3" start_line="70" end_line="70" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="16044" token="0x6000051" name="GetById_ShouldThrow_WhenNotFound()" namespace="HealthAppTests.Service_Layer" type_name="PatientServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="74" end_line="74" start_column="9" end_column="10" covered="yes" />
            <range source_id="3" start_line="75" end_line="76" start_column="13" end_column="47" covered="yes" />
            <range source_id="3" start_line="78" end_line="79" start_column="13" end_column="45" covered="yes" />
            <range source_id="3" start_line="80" end_line="80" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="16184" token="0x6000052" name="UpdatePatientById_ShouldReturnSuccessMessage()" namespace="HealthAppTests.Service_Layer" type_name="PatientServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="19" blocks_not_covered="0" lines_covered="11" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="84" end_line="84" start_column="9" end_column="10" covered="yes" />
            <range source_id="3" start_line="85" end_line="89" start_column="13" end_column="15" covered="yes" />
            <range source_id="3" start_line="91" end_line="92" start_column="13" end_column="40" covered="yes" />
            <range source_id="3" start_line="94" end_line="94" start_column="13" end_column="65" covered="yes" />
            <range source_id="3" start_line="96" end_line="96" start_column="13" end_column="76" covered="yes" />
            <range source_id="3" start_line="97" end_line="97" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="16416" token="0x6000053" name="UpdatePatientById_ShouldThrowException_WhenNotFound()" namespace="HealthAppTests.Service_Layer" type_name="PatientServiceTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="17" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="101" end_line="101" start_column="9" end_column="10" covered="yes" />
            <range source_id="3" start_line="102" end_line="102" start_column="13" end_column="41" covered="yes" />
            <range source_id="3" start_line="104" end_line="105" start_column="13" end_column="47" covered="yes" />
            <range source_id="3" start_line="107" end_line="108" start_column="13" end_column="57" covered="yes" />
            <range source_id="3" start_line="109" end_line="109" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="16611" token="0x6000054" name="&lt;GetById_ShouldThrow_WhenNotFound&gt;b__6_1()" namespace="HealthAppTests.Service_Layer" type_name="PatientServiceTests" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="79" end_line="79" start_column="17" end_column="43" covered="partial" />
          </ranges>
        </function>
        <function id="16625" token="0x6000055" name="AppointmentRepositoryTests()" namespace="HealthAppTests.Repository_Layer" type_name="AppointmentRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="6" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="15" end_line="15" start_column="9" end_column="44" covered="yes" />
            <range source_id="4" start_line="16" end_line="16" start_column="9" end_column="10" covered="yes" />
            <range source_id="4" start_line="17" end_line="17" start_column="13" end_column="39" covered="yes" />
            <range source_id="4" start_line="18" end_line="18" start_column="13" end_column="38" covered="yes" />
            <range source_id="4" start_line="19" end_line="19" start_column="13" end_column="52" covered="yes" />
            <range source_id="4" start_line="20" end_line="20" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="16680" token="0x6000056" name="Add_ShouldAddAppointment()" namespace="HealthAppTests.Repository_Layer" type_name="AppointmentRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="8" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="24" end_line="24" start_column="9" end_column="10" covered="yes" />
            <range source_id="4" start_line="25" end_line="25" start_column="13" end_column="49" covered="yes" />
            <range source_id="4" start_line="27" end_line="27" start_column="13" end_column="42" covered="yes" />
            <range source_id="4" start_line="29" end_line="29" start_column="13" end_column="62" covered="yes" />
            <range source_id="4" start_line="30" end_line="30" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="16753" token="0x6000057" name="Add_ShouldHandleMultipleAppointments()" namespace="HealthAppTests.Repository_Layer" type_name="AppointmentRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="8" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="34" end_line="34" start_column="9" end_column="10" covered="yes" />
            <range source_id="4" start_line="35" end_line="35" start_column="13" end_column="42" covered="yes" />
            <range source_id="4" start_line="36" end_line="36" start_column="13" end_column="42" covered="yes" />
            <range source_id="4" start_line="38" end_line="38" start_column="13" end_column="53" covered="yes" />
            <range source_id="4" start_line="39" end_line="39" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="16816" token="0x6000058" name="GetAll_ShouldReturnAllAppointments()" namespace="HealthAppTests.Repository_Layer" type_name="AppointmentRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="10" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="43" end_line="43" start_column="9" end_column="10" covered="yes" />
            <range source_id="4" start_line="44" end_line="44" start_column="13" end_column="53" covered="yes" />
            <range source_id="4" start_line="45" end_line="45" start_column="13" end_column="53" covered="yes" />
            <range source_id="4" start_line="47" end_line="47" start_column="13" end_column="41" covered="yes" />
            <range source_id="4" start_line="49" end_line="49" start_column="13" end_column="43" covered="yes" />
            <range source_id="4" start_line="50" end_line="50" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="16900" token="0x6000059" name="GetAll_ShouldReturnEmptyList()" namespace="HealthAppTests.Repository_Layer" type_name="AppointmentRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="54" end_line="54" start_column="9" end_column="10" covered="yes" />
            <range source_id="4" start_line="55" end_line="55" start_column="13" end_column="41" covered="yes" />
            <range source_id="4" start_line="57" end_line="57" start_column="13" end_column="34" covered="yes" />
            <range source_id="4" start_line="58" end_line="58" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="16936" token="0x600005a" name="GetById_ShouldReturnAppointment()" namespace="HealthAppTests.Repository_Layer" type_name="AppointmentRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="7" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="62" end_line="62" start_column="9" end_column="10" covered="yes" />
            <range source_id="4" start_line="63" end_line="63" start_column="13" end_column="69" covered="yes" />
            <range source_id="4" start_line="64" end_line="64" start_column="13" end_column="47" covered="yes" />
            <range source_id="4" start_line="66" end_line="66" start_column="13" end_column="43" covered="yes" />
            <range source_id="4" start_line="68" end_line="68" start_column="13" end_column="36" covered="yes" />
            <range source_id="4" start_line="69" end_line="69" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17004" token="0x600005b" name="GetById_ShouldReturnNull_WhenNotFound()" namespace="HealthAppTests.Repository_Layer" type_name="AppointmentRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="73" end_line="73" start_column="9" end_column="10" covered="yes" />
            <range source_id="4" start_line="74" end_line="74" start_column="13" end_column="45" covered="yes" />
            <range source_id="4" start_line="76" end_line="76" start_column="13" end_column="33" covered="yes" />
            <range source_id="4" start_line="77" end_line="77" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17042" token="0x600005c" name="DoctorRepositoryTests()" namespace="HealthAppTests.Repository_Layer" type_name="DoctorRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="6" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="15" end_line="15" start_column="9" end_column="39" covered="yes" />
            <range source_id="5" start_line="16" end_line="16" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="17" end_line="17" start_column="13" end_column="34" covered="yes" />
            <range source_id="5" start_line="18" end_line="18" start_column="13" end_column="33" covered="yes" />
            <range source_id="5" start_line="19" end_line="19" start_column="13" end_column="47" covered="yes" />
            <range source_id="5" start_line="20" end_line="20" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17100" token="0x600005d" name="Add_ShouldAddDoctor()" namespace="HealthAppTests.Repository_Layer" type_name="DoctorRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="6" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="24" end_line="24" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="25" end_line="25" start_column="13" end_column="54" covered="yes" />
            <range source_id="5" start_line="27" end_line="27" start_column="13" end_column="31" covered="yes" />
            <range source_id="5" start_line="29" end_line="29" start_column="13" end_column="40" covered="yes" />
            <range source_id="5" start_line="30" end_line="30" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17160" token="0x600005e" name="GetAll_ShouldReturnDoctors()" namespace="HealthAppTests.Repository_Layer" type_name="DoctorRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="6" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="34" end_line="34" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="35" end_line="35" start_column="13" end_column="43" covered="yes" />
            <range source_id="5" start_line="37" end_line="37" start_column="13" end_column="41" covered="yes" />
            <range source_id="5" start_line="39" end_line="39" start_column="13" end_column="35" covered="yes" />
            <range source_id="5" start_line="40" end_line="40" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17216" token="0x600005f" name="GetAll_ShouldReturnEmpty_WhenNoDoctors()" namespace="HealthAppTests.Repository_Layer" type_name="DoctorRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="44" end_line="44" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="45" end_line="45" start_column="13" end_column="41" covered="yes" />
            <range source_id="5" start_line="47" end_line="47" start_column="13" end_column="34" covered="yes" />
            <range source_id="5" start_line="48" end_line="48" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17252" token="0x6000060" name="GetById_ShouldReturnDoctor()" namespace="HealthAppTests.Repository_Layer" type_name="DoctorRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="9" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="52" end_line="52" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="53" end_line="53" start_column="13" end_column="54" covered="yes" />
            <range source_id="5" start_line="54" end_line="54" start_column="13" end_column="37" covered="yes" />
            <range source_id="5" start_line="56" end_line="56" start_column="13" end_column="43" covered="yes" />
            <range source_id="5" start_line="58" end_line="58" start_column="13" end_column="36" covered="yes" />
            <range source_id="5" start_line="59" end_line="59" start_column="13" end_column="46" covered="yes" />
            <range source_id="5" start_line="60" end_line="60" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17332" token="0x6000061" name="GetById_ShouldReturnNull_WhenNotFound()" namespace="HealthAppTests.Repository_Layer" type_name="DoctorRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="64" end_line="64" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="65" end_line="65" start_column="13" end_column="45" covered="yes" />
            <range source_id="5" start_line="67" end_line="67" start_column="13" end_column="33" covered="yes" />
            <range source_id="5" start_line="68" end_line="68" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17372" token="0x6000062" name="ChangeDoctorStatus_ShouldUpdateStatus()" namespace="HealthAppTests.Repository_Layer" type_name="DoctorRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="12" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="72" end_line="72" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="73" end_line="77" start_column="13" end_column="15" covered="yes" />
            <range source_id="5" start_line="79" end_line="79" start_column="13" end_column="37" covered="yes" />
            <range source_id="5" start_line="81" end_line="81" start_column="13" end_column="61" covered="yes" />
            <range source_id="5" start_line="83" end_line="83" start_column="13" end_column="36" covered="yes" />
            <range source_id="5" start_line="84" end_line="84" start_column="13" end_column="43" covered="yes" />
            <range source_id="5" start_line="86" end_line="86" start_column="13" end_column="51" covered="yes" />
            <range source_id="5" start_line="87" end_line="87" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17488" token="0x6000063" name="ChangeDoctorStatus_ShouldReturnNull_WhenNotFound()" namespace="HealthAppTests.Repository_Layer" type_name="DoctorRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="90" end_line="90" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="91" end_line="91" start_column="13" end_column="62" covered="yes" />
            <range source_id="5" start_line="93" end_line="93" start_column="13" end_column="33" covered="yes" />
            <range source_id="5" start_line="94" end_line="94" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17527" token="0x6000064" name="HealthRecordRepositoryTests()" namespace="HealthAppTests.Repository_Layer" type_name="HealthRecordRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="6" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="6" start_line="15" end_line="15" start_column="9" end_column="45" covered="yes" />
            <range source_id="6" start_line="16" end_line="16" start_column="9" end_column="10" covered="yes" />
            <range source_id="6" start_line="17" end_line="17" start_column="13" end_column="40" covered="yes" />
            <range source_id="6" start_line="18" end_line="18" start_column="13" end_column="33" covered="yes" />
            <range source_id="6" start_line="19" end_line="19" start_column="13" end_column="53" covered="yes" />
            <range source_id="6" start_line="20" end_line="20" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17584" token="0x6000065" name="Add_ShouldAddHealthRecord()" namespace="HealthAppTests.Repository_Layer" type_name="HealthRecordRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="9" blocks_not_covered="0" lines_covered="9" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="6" start_line="24" end_line="24" start_column="9" end_column="10" covered="yes" />
            <range source_id="6" start_line="25" end_line="25" start_column="13" end_column="44" covered="yes" />
            <range source_id="6" start_line="27" end_line="30" start_column="13" end_column="15" covered="yes" />
            <range source_id="6" start_line="32" end_line="32" start_column="13" end_column="31" covered="yes" />
            <range source_id="6" start_line="34" end_line="34" start_column="13" end_column="57" covered="yes" />
            <range source_id="6" start_line="35" end_line="35" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17671" token="0x6000066" name="Add_ShouldHandleMultipleRecords()" namespace="HealthAppTests.Repository_Layer" type_name="HealthRecordRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="8" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="6" start_line="39" end_line="39" start_column="9" end_column="10" covered="yes" />
            <range source_id="6" start_line="40" end_line="40" start_column="13" end_column="43" covered="yes" />
            <range source_id="6" start_line="41" end_line="41" start_column="13" end_column="43" covered="yes" />
            <range source_id="6" start_line="43" end_line="43" start_column="13" end_column="48" covered="yes" />
            <range source_id="6" start_line="44" end_line="44" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17732" token="0x6000067" name="GetAll_ShouldReturnAllRecords()" namespace="HealthAppTests.Repository_Layer" type_name="HealthRecordRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="10" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="6" start_line="48" end_line="48" start_column="9" end_column="10" covered="yes" />
            <range source_id="6" start_line="49" end_line="49" start_column="13" end_column="49" covered="yes" />
            <range source_id="6" start_line="50" end_line="50" start_column="13" end_column="49" covered="yes" />
            <range source_id="6" start_line="52" end_line="52" start_column="13" end_column="41" covered="yes" />
            <range source_id="6" start_line="54" end_line="54" start_column="13" end_column="43" covered="yes" />
            <range source_id="6" start_line="55" end_line="55" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17816" token="0x6000068" name="GetAll_ShouldReturnEmptyList_WhenNoRecords()" namespace="HealthAppTests.Repository_Layer" type_name="HealthRecordRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="6" start_line="59" end_line="59" start_column="9" end_column="10" covered="yes" />
            <range source_id="6" start_line="60" end_line="60" start_column="13" end_column="41" covered="yes" />
            <range source_id="6" start_line="62" end_line="62" start_column="13" end_column="34" covered="yes" />
            <range source_id="6" start_line="63" end_line="63" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17849" token="0x6000069" name="PatientRepositoryTests()" namespace="HealthAppTests.Repository_Layer" type_name="PatientRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="6" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="15" end_line="15" start_column="9" end_column="40" covered="yes" />
            <range source_id="7" start_line="16" end_line="16" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="17" end_line="17" start_column="13" end_column="35" covered="yes" />
            <range source_id="7" start_line="18" end_line="18" start_column="13" end_column="34" covered="yes" />
            <range source_id="7" start_line="19" end_line="19" start_column="13" end_column="48" covered="yes" />
            <range source_id="7" start_line="20" end_line="20" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17904" token="0x600006a" name="Add_ShouldAddPatient()" namespace="HealthAppTests.Repository_Layer" type_name="PatientRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="6" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="24" end_line="24" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="25" end_line="25" start_column="13" end_column="57" covered="yes" />
            <range source_id="7" start_line="27" end_line="27" start_column="13" end_column="32" covered="yes" />
            <range source_id="7" start_line="29" end_line="29" start_column="13" end_column="41" covered="yes" />
            <range source_id="7" start_line="30" end_line="30" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="17964" token="0x600006b" name="GetAll_ShouldReturnPatients()" namespace="HealthAppTests.Repository_Layer" type_name="PatientRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="10" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="34" end_line="34" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="35" end_line="35" start_column="13" end_column="45" covered="yes" />
            <range source_id="7" start_line="36" end_line="36" start_column="13" end_column="45" covered="yes" />
            <range source_id="7" start_line="38" end_line="38" start_column="13" end_column="41" covered="yes" />
            <range source_id="7" start_line="40" end_line="40" start_column="13" end_column="43" covered="yes" />
            <range source_id="7" start_line="41" end_line="41" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="18048" token="0x600006c" name="GetAll_ShouldReturnEmpty_WhenNoData()" namespace="HealthAppTests.Repository_Layer" type_name="PatientRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="45" end_line="45" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="46" end_line="46" start_column="13" end_column="41" covered="yes" />
            <range source_id="7" start_line="48" end_line="48" start_column="13" end_column="34" covered="yes" />
            <range source_id="7" start_line="49" end_line="49" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="18084" token="0x600006d" name="GetById_ShouldReturnPatient()" namespace="HealthAppTests.Repository_Layer" type_name="PatientRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="9" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="53" end_line="53" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="54" end_line="54" start_column="13" end_column="57" covered="yes" />
            <range source_id="7" start_line="55" end_line="55" start_column="13" end_column="39" covered="yes" />
            <range source_id="7" start_line="57" end_line="57" start_column="13" end_column="43" covered="yes" />
            <range source_id="7" start_line="59" end_line="59" start_column="13" end_column="36" covered="yes" />
            <range source_id="7" start_line="60" end_line="60" start_column="13" end_column="47" covered="yes" />
            <range source_id="7" start_line="61" end_line="61" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="18164" token="0x600006e" name="GetById_ShouldReturnNull_WhenNotFound()" namespace="HealthAppTests.Repository_Layer" type_name="PatientRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="65" end_line="65" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="66" end_line="66" start_column="13" end_column="44" covered="yes" />
            <range source_id="7" start_line="68" end_line="68" start_column="13" end_column="33" covered="yes" />
            <range source_id="7" start_line="69" end_line="69" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="18200" token="0x600006f" name="UpdatePatient_ShouldUpdatePatient()" namespace="HealthAppTests.Repository_Layer" type_name="PatientRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="15" blocks_not_covered="0" lines_covered="17" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="73" end_line="73" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="74" end_line="78" start_column="13" end_column="15" covered="yes" />
            <range source_id="7" start_line="80" end_line="80" start_column="13" end_column="40" covered="yes" />
            <range source_id="7" start_line="82" end_line="86" start_column="13" end_column="15" covered="yes" />
            <range source_id="7" start_line="88" end_line="88" start_column="13" end_column="58" covered="yes" />
            <range source_id="7" start_line="90" end_line="90" start_column="13" end_column="36" covered="yes" />
            <range source_id="7" start_line="91" end_line="91" start_column="13" end_column="55" covered="yes" />
            <range source_id="7" start_line="92" end_line="92" start_column="13" end_column="57" covered="yes" />
            <range source_id="7" start_line="93" end_line="93" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="18344" token="0x6000070" name="UpdatePatient_ShouldReturnNull_WhenNotFound()" namespace="HealthAppTests.Repository_Layer" type_name="PatientRepositoryTests" block_coverage="100.00" line_coverage="100.00" blocks_covered="4" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="97" end_line="97" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="98" end_line="98" start_column="13" end_column="65" covered="yes" />
            <range source_id="7" start_line="100" end_line="100" start_column="13" end_column="33" covered="yes" />
            <range source_id="7" start_line="101" end_line="101" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="18414" token="0x6000074" name="&lt;BookAppointment_ShouldThrowPatientConflict&gt;b__1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests.&lt;&gt;c__DisplayClass10_0" block_coverage="83.33" line_coverage="0.00" blocks_covered="5" blocks_not_covered="1" lines_covered="0" lines_partially_covered="5" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="98" end_line="102" start_column="17" end_column="35" covered="partial" />
          </ranges>
        </function>
        <function id="18474" token="0x6000076" name="&lt;BookAppointment_ShouldThrow_WhenSameSlotBookedByPatient&gt;b__1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests.&lt;&gt;c__DisplayClass11_0" block_coverage="75.00" line_coverage="0.00" blocks_covered="3" blocks_not_covered="1" lines_covered="0" lines_partially_covered="5" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="125" end_line="129" start_column="17" end_column="50" covered="partial" />
          </ranges>
        </function>
        <function id="18535" token="0x6000078" name="&lt;BookAppointment_ShouldThrowSlotConflict&gt;b__1()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests.&lt;&gt;c__DisplayClass12_0" block_coverage="85.71" line_coverage="0.00" blocks_covered="6" blocks_not_covered="1" lines_covered="0" lines_partially_covered="5" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="141" end_line="145" start_column="17" end_column="35" covered="partial" />
          </ranges>
        </function>
        <function id="18603" token="0x600007a" name="&lt;CheckDoctorAvailability_ShouldThrowSlotAlreadyOverException&gt;b__0(string)" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests.&lt;&gt;c__DisplayClass31_0" block_coverage="100.00" line_coverage="100.00" blocks_covered="7" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="362" end_line="367" start_column="63" end_column="14" covered="yes" />
          </ranges>
        </function>
        <function id="18656" token="0x600007b" name="&lt;CheckDoctorAvailability_ShouldThrowSlotAlreadyOverException&gt;b__2()" namespace="HealthAppTests.Service_Layer" type_name="AppointmentServiceTests.&lt;&gt;c__DisplayClass31_0" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="374" end_line="374" start_column="17" end_column="65" covered="partial" />
          </ranges>
        </function>
        <function id="18785" token="0x6000086" name="&lt;UpdatePatientById_ShouldThrowException_WhenNotFound&gt;b__1()" namespace="HealthAppTests.Service_Layer" type_name="PatientServiceTests.&lt;&gt;c__DisplayClass8_0" block_coverage="50.00" line_coverage="0.00" blocks_covered="1" blocks_not_covered="1" lines_covered="0" lines_partially_covered="1" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="108" end_line="108" start_column="17" end_column="55" covered="partial" />
          </ranges>
        </function>
      </functions>
      <source_files>
        <source_file id="0" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthAppTests\Service Layer\AppointmentServiceTests.cs" checksum_type="SHA256" checksum="11347758F7307D156F87651ADA88AE48445DB58F7E2D7DB3D1B522A3B95716A1" />
        <source_file id="1" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthAppTests\Service Layer\DoctorServiceTests.cs" checksum_type="SHA256" checksum="CFD31F7C2A0F69FD19B9174E1B2B797C9DF244F0E3AFBCAF04094A62B52FA88F" />
        <source_file id="2" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthAppTests\Service Layer\HealthRecordServiceTests.cs" checksum_type="SHA256" checksum="90E281A89B7A181C23FDD4AD464EA27F3E3A46DCBFE0FDA21227CEF23F7D59F7" />
        <source_file id="3" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthAppTests\Service Layer\PatientServiceTests.cs" checksum_type="SHA256" checksum="DA99E70EAC7B5788522354E8DCAC2AC6800247DE5727BF182781564DB503F4A3" />
        <source_file id="4" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthAppTests\Repository Layer\AppointmentRepositoryTests.cs" checksum_type="SHA256" checksum="B81784F6C73477CB8F99AD6D9B9F04AC4369C8A49382E1DA55372F3DBC335E42" />
        <source_file id="5" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthAppTests\Repository Layer\DoctorRepositoryTests.cs" checksum_type="SHA256" checksum="712CE796575D629B08D74BA5A9477B7F94AEC63A9BFBF58BEBBB2A2206694688" />
        <source_file id="6" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthAppTests\Repository Layer\HealthRecordRepositoryTests.cs" checksum_type="SHA256" checksum="6D3566D50951AE782029E2D72925FCE8A357DD9E60961F654AF11A855C8D80E1" />
        <source_file id="7" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthAppTests\Repository Layer\PatientRepositoryTests.cs" checksum_type="SHA256" checksum="CDD14BE09BF595A1683F03A0F65DE388044119A90A961BADB45116220A2CE10A" />
      </source_files>
      <skipped_functions>
        <skipped_function id="8272" original_id="8272" token="0x6000001" name="Main(string[])" type_name="AutoGeneratedProgram" reason="attribute_excluded" />
      </skipped_functions>
    </module>
    <module id="6F7038E3264FF545A36C9DB1B7528E8AB01AAAE1" name="HealthApp.dll" path="HealthApp.dll" block_coverage="38.78" line_coverage="38.31" blocks_covered="693" blocks_not_covered="1094" lines_covered="611" lines_partially_covered="38" lines_not_covered="946">
      <functions>
        <function id="8615" token="0x6000016" name="AppointmentService(HealthApp.Repository.Interface.IAppointmentRepository)" namespace="HealthApp.Service.Impl" type_name="AppointmentService" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="20" end_line="21" start_column="9" end_column="41" covered="yes" />
            <range source_id="0" start_line="22" end_line="22" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="23" end_line="23" start_column="13" end_column="26" covered="yes" />
            <range source_id="0" start_line="24" end_line="24" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="8632" token="0x6000017" name="BookAppointment(HealthApp.Model.Patient, HealthApp.Model.Doctor, System.DateTime, string)" namespace="HealthApp.Service.Impl" type_name="AppointmentService" block_coverage="77.59" line_coverage="82.14" blocks_covered="45" blocks_not_covered="13" lines_covered="69" lines_partially_covered="0" lines_not_covered="15">
          <ranges>
            <range source_id="0" start_line="31" end_line="31" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="32" end_line="32" start_column="13" end_column="44" covered="yes" />
            <range source_id="0" start_line="33" end_line="33" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="34" end_line="35" start_column="17" end_column="47" covered="yes" />
            <range source_id="0" start_line="38" end_line="38" start_column="13" end_column="34" covered="yes" />
            <range source_id="0" start_line="39" end_line="39" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="40" end_line="41" start_column="17" end_column="44" covered="yes" />
            <range source_id="0" start_line="44" end_line="44" start_column="13" end_column="49" covered="yes" />
            <range source_id="0" start_line="45" end_line="45" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="46" end_line="47" start_column="17" end_column="38" covered="yes" />
            <range source_id="0" start_line="53" end_line="53" start_column="13" end_column="45" covered="yes" />
            <range source_id="0" start_line="54" end_line="54" start_column="13" end_column="14" covered="no" />
            <range source_id="0" start_line="55" end_line="58" start_column="17" end_column="51" covered="no" />
            <range source_id="0" start_line="60" end_line="61" start_column="17" end_column="52" covered="no" />
            <range source_id="0" start_line="63" end_line="63" start_column="17" end_column="46" covered="no" />
            <range source_id="0" start_line="64" end_line="64" start_column="17" end_column="18" covered="no" />
            <range source_id="0" start_line="65" end_line="66" start_column="21" end_column="47" covered="no" />
            <range source_id="0" start_line="68" end_line="68" start_column="13" end_column="14" covered="no" />
            <range source_id="0" start_line="71" end_line="79" start_column="13" end_column="58" covered="yes" />
            <range source_id="0" start_line="81" end_line="81" start_column="13" end_column="34" covered="yes" />
            <range source_id="0" start_line="82" end_line="82" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="83" end_line="84" start_column="17" end_column="82" covered="yes" />
            <range source_id="0" start_line="89" end_line="97" start_column="13" end_column="58" covered="yes" />
            <range source_id="0" start_line="99" end_line="99" start_column="13" end_column="32" covered="yes" />
            <range source_id="0" start_line="100" end_line="100" start_column="13" end_column="14" covered="no" />
            <range source_id="0" start_line="101" end_line="102" start_column="17" end_column="80" covered="no" />
            <range source_id="0" start_line="105" end_line="116" start_column="13" end_column="50" covered="yes" />
            <range source_id="0" start_line="118" end_line="118" start_column="13" end_column="31" covered="yes" />
            <range source_id="0" start_line="119" end_line="119" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="120" end_line="121" start_column="17" end_column="45" covered="yes" />
            <range source_id="0" start_line="124" end_line="136" start_column="13" end_column="15" covered="yes" />
            <range source_id="0" start_line="140" end_line="140" start_column="13" end_column="36" covered="yes" />
            <range source_id="0" start_line="142" end_line="142" start_column="13" end_column="32" covered="yes" />
            <range source_id="0" start_line="143" end_line="143" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9148" token="0x6000018" name="CancelAppointment(int, string)" namespace="HealthApp.Service.Impl" type_name="AppointmentService" block_coverage="100.00" line_coverage="100.00" blocks_covered="21" blocks_not_covered="0" lines_covered="17" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="148" end_line="148" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="149" end_line="150" start_column="13" end_column="46" covered="yes" />
            <range source_id="0" start_line="152" end_line="152" start_column="13" end_column="37" covered="yes" />
            <range source_id="0" start_line="153" end_line="153" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="154" end_line="154" start_column="17" end_column="110" covered="yes" />
            <range source_id="0" start_line="157" end_line="157" start_column="13" end_column="67" covered="yes" />
            <range source_id="0" start_line="158" end_line="158" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="160" end_line="160" start_column="17" end_column="107" covered="yes" />
            <range source_id="0" start_line="163" end_line="163" start_column="13" end_column="67" covered="yes" />
            <range source_id="0" start_line="164" end_line="164" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="165" end_line="165" start_column="17" end_column="111" covered="yes" />
            <range source_id="0" start_line="168" end_line="168" start_column="13" end_column="37" covered="yes" />
            <range source_id="0" start_line="169" end_line="169" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="170" end_line="170" start_column="17" end_column="44" covered="yes" />
            <range source_id="0" start_line="171" end_line="171" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="172" end_line="172" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9316" token="0x6000019" name="GetAppointmentById(int)" namespace="HealthApp.Service.Impl" type_name="AppointmentService" block_coverage="100.00" line_coverage="100.00" blocks_covered="11" blocks_not_covered="0" lines_covered="8" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="175" end_line="175" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="176" end_line="176" start_column="13" end_column="49" covered="yes" />
            <range source_id="0" start_line="178" end_line="178" start_column="13" end_column="37" covered="yes" />
            <range source_id="0" start_line="179" end_line="179" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="180" end_line="181" start_column="17" end_column="60" covered="yes" />
            <range source_id="0" start_line="184" end_line="184" start_column="13" end_column="32" covered="yes" />
            <range source_id="0" start_line="185" end_line="185" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9416" token="0x600001a" name="GetAllAppointments()" namespace="HealthApp.Service.Impl" type_name="AppointmentService" block_coverage="100.00" line_coverage="100.00" blocks_covered="10" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="188" end_line="188" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="189" end_line="189" start_column="13" end_column="39" covered="yes" />
            <range source_id="0" start_line="191" end_line="191" start_column="13" end_column="49" covered="yes" />
            <range source_id="0" start_line="192" end_line="192" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="193" end_line="193" start_column="17" end_column="81" covered="yes" />
            <range source_id="0" start_line="196" end_line="196" start_column="13" end_column="25" covered="yes" />
            <range source_id="0" start_line="197" end_line="197" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9480" token="0x600001b" name="GetAppointmentsByPatient(int)" namespace="HealthApp.Service.Impl" type_name="AppointmentService" block_coverage="72.73" line_coverage="88.24" blocks_covered="16" blocks_not_covered="6" lines_covered="15" lines_partially_covered="0" lines_not_covered="2">
          <ranges>
            <range source_id="0" start_line="202" end_line="202" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="203" end_line="213" start_column="13" end_column="27" covered="yes" />
            <range source_id="0" start_line="214" end_line="214" start_column="13" end_column="35" covered="yes" />
            <range source_id="0" start_line="215" end_line="215" start_column="13" end_column="14" covered="no" />
            <range source_id="0" start_line="216" end_line="216" start_column="17" end_column="114" covered="no" />
            <range source_id="0" start_line="219" end_line="219" start_column="13" end_column="27" covered="yes" />
            <range source_id="0" start_line="220" end_line="220" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9684" token="0x600001c" name="GetUpcomingAppointmentsByDoctor(int, System.DateTime, System.DateTime)" namespace="HealthApp.Service.Impl" type_name="AppointmentService" block_coverage="81.25" line_coverage="86.96" blocks_covered="26" blocks_not_covered="6" lines_covered="20" lines_partially_covered="0" lines_not_covered="3">
          <ranges>
            <range source_id="0" start_line="225" end_line="225" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="226" end_line="226" start_column="13" end_column="48" covered="yes" />
            <range source_id="0" start_line="227" end_line="227" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="228" end_line="228" start_column="17" end_column="88" covered="yes" />
            <range source_id="0" start_line="231" end_line="231" start_column="13" end_column="35" covered="yes" />
            <range source_id="0" start_line="232" end_line="232" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="233" end_line="233" start_column="17" end_column="75" covered="yes" />
            <range source_id="0" start_line="236" end_line="245" start_column="13" end_column="27" covered="yes" />
            <range source_id="0" start_line="247" end_line="247" start_column="13" end_column="35" covered="yes" />
            <range source_id="0" start_line="248" end_line="248" start_column="13" end_column="14" covered="no" />
            <range source_id="0" start_line="249" end_line="250" start_column="17" end_column="81" covered="no" />
            <range source_id="0" start_line="253" end_line="253" start_column="13" end_column="27" covered="yes" />
            <range source_id="0" start_line="254" end_line="254" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="9976" token="0x600001d" name="CheckDoctorAvailability(int, System.DateTime)" namespace="HealthApp.Service.Impl" type_name="AppointmentService" block_coverage="100.00" line_coverage="100.00" blocks_covered="29" blocks_not_covered="0" lines_covered="29" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="259" end_line="259" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="261" end_line="261" start_column="13" end_column="44" covered="yes" />
            <range source_id="0" start_line="262" end_line="262" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="263" end_line="264" start_column="17" end_column="59" covered="yes" />
            <range source_id="0" start_line="268" end_line="268" start_column="13" end_column="56" covered="yes" />
            <range source_id="0" start_line="269" end_line="269" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="270" end_line="271" start_column="17" end_column="84" covered="yes" />
            <range source_id="0" start_line="275" end_line="284" start_column="13" end_column="27" covered="yes" />
            <range source_id="0" start_line="287" end_line="290" start_column="13" end_column="27" covered="yes" />
            <range source_id="0" start_line="293" end_line="293" start_column="13" end_column="43" covered="yes" />
            <range source_id="0" start_line="294" end_line="294" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="295" end_line="296" start_column="17" end_column="56" covered="yes" />
            <range source_id="0" start_line="299" end_line="299" start_column="13" end_column="35" covered="yes" />
            <range source_id="0" start_line="300" end_line="300" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10228" token="0x600001e" name="GetPendingAppointmentsByDoctor(int)" namespace="HealthApp.Service.Impl" type_name="AppointmentService" block_coverage="100.00" line_coverage="100.00" blocks_covered="22" blocks_not_covered="0" lines_covered="14" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="304" end_line="304" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="305" end_line="312" start_column="13" end_column="27" covered="yes" />
            <range source_id="0" start_line="313" end_line="313" start_column="13" end_column="35" covered="yes" />
            <range source_id="0" start_line="314" end_line="314" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="315" end_line="315" start_column="17" end_column="115" covered="yes" />
            <range source_id="0" start_line="317" end_line="317" start_column="13" end_column="27" covered="yes" />
            <range source_id="0" start_line="318" end_line="318" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10432" token="0x600001f" name="ConfirmAppointment(int)" namespace="HealthApp.Service.Impl" type_name="AppointmentService" block_coverage="60.87" line_coverage="76.19" blocks_covered="14" blocks_not_covered="9" lines_covered="16" lines_partially_covered="0" lines_not_covered="5">
          <ranges>
            <range source_id="0" start_line="321" end_line="321" start_column="9" end_column="10" covered="yes" />
            <range source_id="0" start_line="322" end_line="323" start_column="13" end_column="46" covered="yes" />
            <range source_id="0" start_line="325" end_line="325" start_column="13" end_column="37" covered="yes" />
            <range source_id="0" start_line="326" end_line="326" start_column="13" end_column="14" covered="no" />
            <range source_id="0" start_line="327" end_line="328" start_column="17" end_column="71" covered="no" />
            <range source_id="0" start_line="331" end_line="332" start_column="13" end_column="45" covered="yes" />
            <range source_id="0" start_line="333" end_line="333" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="334" end_line="335" start_column="17" end_column="67" covered="yes" />
            <range source_id="0" start_line="337" end_line="337" start_column="13" end_column="67" covered="yes" />
            <range source_id="0" start_line="338" end_line="338" start_column="13" end_column="14" covered="yes" />
            <range source_id="0" start_line="339" end_line="340" start_column="17" end_column="61" covered="yes" />
            <range source_id="0" start_line="342" end_line="342" start_column="13" end_column="67" covered="yes" />
            <range source_id="0" start_line="343" end_line="343" start_column="13" end_column="14" covered="no" />
            <range source_id="0" start_line="344" end_line="344" start_column="17" end_column="111" covered="no" />
            <range source_id="0" start_line="347" end_line="347" start_column="13" end_column="35" covered="yes" />
            <range source_id="0" start_line="348" end_line="348" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10612" token="0x6000020" name="DoctorService(HealthApp.Repository.Interface.IDoctorRepository)" namespace="HealthApp.Service.Impl" type_name="DoctorService" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="15" end_line="15" start_column="9" end_column="53" covered="yes" />
            <range source_id="1" start_line="16" end_line="16" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="17" end_line="17" start_column="13" end_column="26" covered="yes" />
            <range source_id="1" start_line="18" end_line="18" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10632" token="0x6000021" name="AddDoctor(HealthApp.Model.Doctor)" namespace="HealthApp.Service.Impl" type_name="DoctorService" block_coverage="57.14" line_coverage="69.23" blocks_covered="8" blocks_not_covered="6" lines_covered="9" lines_partially_covered="0" lines_not_covered="4">
          <ranges>
            <range source_id="1" start_line="21" end_line="21" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="22" end_line="22" start_column="13" end_column="42" covered="yes" />
            <range source_id="1" start_line="24" end_line="24" start_column="13" end_column="35" covered="yes" />
            <range source_id="1" start_line="25" end_line="25" start_column="13" end_column="14" covered="no" />
            <range source_id="1" start_line="26" end_line="27" start_column="17" end_column="54" covered="no" />
            <range source_id="1" start_line="28" end_line="28" start_column="13" end_column="14" covered="no" />
            <range source_id="1" start_line="30" end_line="30" start_column="13" end_column="14" covered="yes" />
            <range source_id="1" start_line="31" end_line="31" start_column="17" end_column="37" covered="yes" />
            <range source_id="1" start_line="32" end_line="32" start_column="13" end_column="14" covered="yes" />
            <range source_id="1" start_line="34" end_line="34" start_column="13" end_column="36" covered="yes" />
            <range source_id="1" start_line="36" end_line="36" start_column="13" end_column="31" covered="yes" />
            <range source_id="1" start_line="37" end_line="37" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10752" token="0x6000022" name="GetAllDoctors()" namespace="HealthApp.Service.Impl" type_name="DoctorService" block_coverage="100.00" line_coverage="100.00" blocks_covered="7" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="40" end_line="40" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="41" end_line="41" start_column="13" end_column="41" covered="yes" />
            <range source_id="1" start_line="43" end_line="43" start_column="13" end_column="35" covered="yes" />
            <range source_id="1" start_line="44" end_line="44" start_column="13" end_column="14" covered="yes" />
            <range source_id="1" start_line="45" end_line="45" start_column="17" end_column="91" covered="yes" />
            <range source_id="1" start_line="47" end_line="47" start_column="13" end_column="27" covered="yes" />
            <range source_id="1" start_line="48" end_line="48" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10808" token="0x6000023" name="GetDoctorById(int)" namespace="HealthApp.Service.Impl" type_name="DoctorService" block_coverage="100.00" line_coverage="100.00" blocks_covered="11" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="51" end_line="51" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="53" end_line="53" start_column="13" end_column="44" covered="yes" />
            <range source_id="1" start_line="54" end_line="54" start_column="13" end_column="32" covered="yes" />
            <range source_id="1" start_line="55" end_line="55" start_column="13" end_column="14" covered="yes" />
            <range source_id="1" start_line="56" end_line="56" start_column="17" end_column="85" covered="yes" />
            <range source_id="1" start_line="59" end_line="59" start_column="13" end_column="27" covered="yes" />
            <range source_id="1" start_line="60" end_line="60" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="10908" token="0x6000024" name="SearchBySpecialisation(HealthApp.Model.SpecialisationType)" namespace="HealthApp.Service.Impl" type_name="DoctorService" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="9" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="63" end_line="63" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="64" end_line="66" start_column="13" end_column="27" covered="yes" />
            <range source_id="1" start_line="68" end_line="68" start_column="13" end_column="35" covered="yes" />
            <range source_id="1" start_line="69" end_line="69" start_column="13" end_column="14" covered="yes" />
            <range source_id="1" start_line="70" end_line="70" start_column="17" end_column="112" covered="yes" />
            <range source_id="1" start_line="73" end_line="73" start_column="13" end_column="27" covered="yes" />
            <range source_id="1" start_line="74" end_line="74" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11040" token="0x6000025" name="ChangeDoctorStatus(int, bool)" namespace="HealthApp.Service.Impl" type_name="DoctorService" block_coverage="78.26" line_coverage="70.00" blocks_covered="18" blocks_not_covered="5" lines_covered="7" lines_partially_covered="3" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="78" end_line="78" start_column="9" end_column="10" covered="yes" />
            <range source_id="1" start_line="79" end_line="79" start_column="13" end_column="65" covered="yes" />
            <range source_id="1" start_line="81" end_line="81" start_column="13" end_column="32" covered="yes" />
            <range source_id="1" start_line="82" end_line="82" start_column="13" end_column="14" covered="yes" />
            <range source_id="1" start_line="83" end_line="84" start_column="17" end_column="55" covered="yes" />
            <range source_id="1" start_line="87" end_line="89" start_column="13" end_column="58" covered="partial" />
            <range source_id="1" start_line="90" end_line="90" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11250" token="0x6000026" name="HealthRecordService(HealthApp.Repository.Interface.IHealthRecordRepository)" namespace="HealthApp.Service.Impl" type_name="HealthRecordService" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="17" end_line="18" start_column="9" end_column="42" covered="yes" />
            <range source_id="2" start_line="19" end_line="19" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="20" end_line="20" start_column="13" end_column="26" covered="yes" />
            <range source_id="2" start_line="21" end_line="21" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11267" token="0x6000027" name="AddRecord(HealthApp.Model.HealthRecord)" namespace="HealthApp.Service.Impl" type_name="HealthRecordService" block_coverage="100.00" line_coverage="100.00" blocks_covered="5" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="24" end_line="24" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="25" end_line="26" start_column="13" end_column="42" covered="yes" />
            <range source_id="2" start_line="28" end_line="28" start_column="13" end_column="31" covered="yes" />
            <range source_id="2" start_line="29" end_line="29" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11308" token="0x6000028" name="GetPatientRecords(int)" namespace="HealthApp.Service.Impl" type_name="HealthRecordService" block_coverage="100.00" line_coverage="100.00" blocks_covered="14" blocks_not_covered="0" lines_covered="11" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="33" end_line="33" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="34" end_line="38" start_column="13" end_column="27" covered="yes" />
            <range source_id="2" start_line="39" end_line="39" start_column="13" end_column="35" covered="yes" />
            <range source_id="2" start_line="40" end_line="40" start_column="13" end_column="14" covered="yes" />
            <range source_id="2" start_line="41" end_line="41" start_column="17" end_column="127" covered="yes" />
            <range source_id="2" start_line="43" end_line="43" start_column="13" end_column="27" covered="yes" />
            <range source_id="2" start_line="44" end_line="44" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11440" token="0x6000029" name="GetHealthRecordsByDoctor(int, int)" namespace="HealthApp.Service.Impl" type_name="HealthRecordService" block_coverage="100.00" line_coverage="100.00" blocks_covered="20" blocks_not_covered="0" lines_covered="13" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="50" end_line="50" start_column="9" end_column="10" covered="yes" />
            <range source_id="2" start_line="51" end_line="57" start_column="13" end_column="27" covered="yes" />
            <range source_id="2" start_line="59" end_line="59" start_column="13" end_column="35" covered="yes" />
            <range source_id="2" start_line="60" end_line="60" start_column="13" end_column="14" covered="yes" />
            <range source_id="2" start_line="62" end_line="62" start_column="17" end_column="175" covered="yes" />
            <range source_id="2" start_line="65" end_line="65" start_column="13" end_column="27" covered="yes" />
            <range source_id="2" start_line="66" end_line="66" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11642" token="0x600002a" name="PatientService(HealthApp.Repository.Interface.IPatientRepository)" namespace="HealthApp.Service.Impl" type_name="PatientService" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="15" end_line="15" start_column="9" end_column="55" covered="yes" />
            <range source_id="3" start_line="16" end_line="16" start_column="9" end_column="10" covered="yes" />
            <range source_id="3" start_line="17" end_line="17" start_column="13" end_column="26" covered="yes" />
            <range source_id="3" start_line="18" end_line="18" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11660" token="0x600002b" name="RegisterPatient(HealthApp.Model.Patient)" namespace="HealthApp.Service.Impl" type_name="PatientService" block_coverage="100.00" line_coverage="100.00" blocks_covered="13" blocks_not_covered="0" lines_covered="12" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="21" end_line="21" start_column="9" end_column="10" covered="yes" />
            <range source_id="3" start_line="22" end_line="22" start_column="13" end_column="43" covered="yes" />
            <range source_id="3" start_line="24" end_line="24" start_column="13" end_column="36" covered="yes" />
            <range source_id="3" start_line="25" end_line="25" start_column="13" end_column="14" covered="yes" />
            <range source_id="3" start_line="26" end_line="27" start_column="17" end_column="56" covered="yes" />
            <range source_id="3" start_line="28" end_line="28" start_column="13" end_column="14" covered="yes" />
            <range source_id="3" start_line="30" end_line="30" start_column="13" end_column="14" covered="yes" />
            <range source_id="3" start_line="31" end_line="31" start_column="17" end_column="39" covered="yes" />
            <range source_id="3" start_line="32" end_line="32" start_column="13" end_column="14" covered="yes" />
            <range source_id="3" start_line="34" end_line="34" start_column="13" end_column="32" covered="yes" />
            <range source_id="3" start_line="35" end_line="35" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11772" token="0x600002c" name="GetPatientById(int)" namespace="HealthApp.Service.Impl" type_name="PatientService" block_coverage="100.00" line_coverage="100.00" blocks_covered="11" blocks_not_covered="0" lines_covered="8" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="38" end_line="38" start_column="9" end_column="10" covered="yes" />
            <range source_id="3" start_line="39" end_line="39" start_column="13" end_column="45" covered="yes" />
            <range source_id="3" start_line="41" end_line="41" start_column="13" end_column="33" covered="yes" />
            <range source_id="3" start_line="42" end_line="42" start_column="13" end_column="14" covered="yes" />
            <range source_id="3" start_line="43" end_line="44" start_column="17" end_column="56" covered="yes" />
            <range source_id="3" start_line="47" end_line="47" start_column="13" end_column="28" covered="yes" />
            <range source_id="3" start_line="48" end_line="48" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="11872" token="0x600002d" name="UpdatePatientById(int, HealthApp.Model.Patient)" namespace="HealthApp.Service.Impl" type_name="PatientService" block_coverage="100.00" line_coverage="100.00" blocks_covered="16" blocks_not_covered="0" lines_covered="8" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="50" end_line="50" start_column="9" end_column="10" covered="yes" />
            <range source_id="3" start_line="51" end_line="51" start_column="13" end_column="67" covered="yes" />
            <range source_id="3" start_line="53" end_line="53" start_column="13" end_column="40" covered="yes" />
            <range source_id="3" start_line="54" end_line="54" start_column="13" end_column="14" covered="yes" />
            <range source_id="3" start_line="55" end_line="56" start_column="17" end_column="56" covered="yes" />
            <range source_id="3" start_line="59" end_line="59" start_column="13" end_column="65" covered="yes" />
            <range source_id="3" start_line="60" end_line="60" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12025" token="0x600003b" name="AppointmentRepository(HealthApp.Database.AppointmentDb)" namespace="HealthApp.Repository.Impl" type_name="AppointmentRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="14" end_line="14" start_column="9" end_column="66" covered="yes" />
            <range source_id="4" start_line="15" end_line="15" start_column="9" end_column="10" covered="yes" />
            <range source_id="4" start_line="16" end_line="16" start_column="13" end_column="44" covered="yes" />
            <range source_id="4" start_line="17" end_line="17" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12042" token="0x600003c" name="Add(HealthApp.Model.Appointment)" namespace="HealthApp.Repository.Impl" type_name="AppointmentRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="19" end_line="19" start_column="9" end_column="10" covered="yes" />
            <range source_id="4" start_line="20" end_line="20" start_column="13" end_column="58" covered="yes" />
            <range source_id="4" start_line="21" end_line="21" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12064" token="0x600003d" name="GetAll()" namespace="HealthApp.Repository.Impl" type_name="AppointmentRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="23" end_line="23" start_column="9" end_column="10" covered="yes" />
            <range source_id="4" start_line="24" end_line="24" start_column="13" end_column="48" covered="yes" />
            <range source_id="4" start_line="25" end_line="25" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12096" token="0x600003e" name="GetById(int)" namespace="HealthApp.Repository.Impl" type_name="AppointmentRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="5" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="27" end_line="27" start_column="9" end_column="10" covered="yes" />
            <range source_id="4" start_line="28" end_line="28" start_column="13" end_column="91" covered="yes" />
            <range source_id="4" start_line="29" end_line="29" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12155" token="0x600003f" name="DoctorRepository(HealthApp.Database.DoctorDb)" namespace="HealthApp.Repository.Impl" type_name="DoctorRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="14" end_line="14" start_column="9" end_column="51" covered="yes" />
            <range source_id="5" start_line="15" end_line="15" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="16" end_line="16" start_column="13" end_column="34" covered="yes" />
            <range source_id="5" start_line="17" end_line="17" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12172" token="0x6000040" name="Add(HealthApp.Model.Doctor)" namespace="HealthApp.Repository.Impl" type_name="DoctorRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="20" end_line="20" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="21" end_line="21" start_column="13" end_column="43" covered="yes" />
            <range source_id="5" start_line="22" end_line="22" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12196" token="0x6000041" name="GetAll()" namespace="HealthApp.Repository.Impl" type_name="DoctorRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="25" end_line="25" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="26" end_line="26" start_column="13" end_column="38" covered="yes" />
            <range source_id="5" start_line="27" end_line="27" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12228" token="0x6000042" name="GetById(int)" namespace="HealthApp.Repository.Impl" type_name="DoctorRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="5" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="30" end_line="30" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="31" end_line="32" start_column="13" end_column="56" covered="yes" />
            <range source_id="5" start_line="34" end_line="34" start_column="13" end_column="27" covered="yes" />
            <range source_id="5" start_line="35" end_line="35" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12292" token="0x6000043" name="ChangeDoctorStatus(int, bool)" namespace="HealthApp.Repository.Impl" type_name="DoctorRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="8" blocks_not_covered="0" lines_covered="9" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="38" end_line="38" start_column="9" end_column="10" covered="yes" />
            <range source_id="5" start_line="39" end_line="40" start_column="13" end_column="74" covered="yes" />
            <range source_id="5" start_line="42" end_line="42" start_column="13" end_column="32" covered="yes" />
            <range source_id="5" start_line="43" end_line="43" start_column="13" end_column="14" covered="yes" />
            <range source_id="5" start_line="44" end_line="44" start_column="17" end_column="29" covered="yes" />
            <range source_id="5" start_line="47" end_line="47" start_column="13" end_column="40" covered="yes" />
            <range source_id="5" start_line="49" end_line="49" start_column="13" end_column="27" covered="yes" />
            <range source_id="5" start_line="50" end_line="50" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12374" token="0x6000044" name="HealthRecordRepository(HealthApp.Database.HealthRecordDb)" namespace="HealthApp.Repository.Impl" type_name="HealthRecordRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="6" start_line="13" end_line="13" start_column="9" end_column="69" covered="yes" />
            <range source_id="6" start_line="14" end_line="14" start_column="9" end_column="10" covered="yes" />
            <range source_id="6" start_line="15" end_line="15" start_column="13" end_column="46" covered="yes" />
            <range source_id="6" start_line="16" end_line="16" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12391" token="0x6000045" name="Add(HealthApp.Model.HealthRecord)" namespace="HealthApp.Repository.Impl" type_name="HealthRecordRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="6" start_line="18" end_line="18" start_column="9" end_column="10" covered="yes" />
            <range source_id="6" start_line="19" end_line="19" start_column="13" end_column="49" covered="yes" />
            <range source_id="6" start_line="20" end_line="20" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12412" token="0x6000046" name="GetAll()" namespace="HealthApp.Repository.Impl" type_name="HealthRecordRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="6" start_line="22" end_line="22" start_column="9" end_column="10" covered="yes" />
            <range source_id="6" start_line="23" end_line="23" start_column="13" end_column="44" covered="yes" />
            <range source_id="6" start_line="24" end_line="24" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12441" token="0x6000047" name="PatientRepository(HealthApp.Database.PatientDb)" namespace="HealthApp.Repository.Impl" type_name="PatientRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="15" end_line="15" start_column="9" end_column="54" covered="yes" />
            <range source_id="7" start_line="16" end_line="16" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="17" end_line="17" start_column="13" end_column="36" covered="yes" />
            <range source_id="7" start_line="18" end_line="18" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12458" token="0x6000048" name="Add(HealthApp.Model.Patient)" namespace="HealthApp.Repository.Impl" type_name="PatientRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="20" end_line="20" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="21" end_line="21" start_column="13" end_column="46" covered="yes" />
            <range source_id="7" start_line="22" end_line="22" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12480" token="0x6000049" name="GetAll()" namespace="HealthApp.Repository.Impl" type_name="PatientRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="25" end_line="25" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="26" end_line="26" start_column="13" end_column="40" covered="yes" />
            <range source_id="7" start_line="27" end_line="27" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12512" token="0x600004a" name="GetById(int)" namespace="HealthApp.Repository.Impl" type_name="PatientRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="5" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="30" end_line="30" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="31" end_line="32" start_column="13" end_column="72" covered="yes" />
            <range source_id="7" start_line="33" end_line="33" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12572" token="0x600004b" name="UpdatePatient(int, HealthApp.Model.Patient)" namespace="HealthApp.Repository.Impl" type_name="PatientRepository" block_coverage="100.00" line_coverage="100.00" blocks_covered="19" blocks_not_covered="0" lines_covered="14" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="36" end_line="36" start_column="9" end_column="10" covered="yes" />
            <range source_id="7" start_line="37" end_line="38" start_column="13" end_column="75" covered="yes" />
            <range source_id="7" start_line="40" end_line="40" start_column="13" end_column="29" covered="yes" />
            <range source_id="7" start_line="41" end_line="41" start_column="13" end_column="14" covered="yes" />
            <range source_id="7" start_line="42" end_line="42" start_column="17" end_column="29" covered="yes" />
            <range source_id="7" start_line="45" end_line="45" start_column="13" end_column="45" covered="yes" />
            <range source_id="7" start_line="46" end_line="46" start_column="13" end_column="51" covered="yes" />
            <range source_id="7" start_line="47" end_line="47" start_column="13" end_column="41" covered="yes" />
            <range source_id="7" start_line="48" end_line="48" start_column="13" end_column="51" covered="yes" />
            <range source_id="7" start_line="49" end_line="49" start_column="13" end_column="39" covered="yes" />
            <range source_id="7" start_line="50" end_line="50" start_column="13" end_column="51" covered="yes" />
            <range source_id="7" start_line="52" end_line="52" start_column="13" end_column="24" covered="yes" />
            <range source_id="7" start_line="53" end_line="53" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12844" token="0x600005a" name="Confirm()" namespace="HealthApp.Model" type_name="Appointment" block_coverage="100.00" line_coverage="100.00" blocks_covered="5" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="8" start_line="33" end_line="33" start_column="9" end_column="10" covered="yes" />
            <range source_id="8" start_line="34" end_line="34" start_column="13" end_column="55" covered="yes" />
            <range source_id="8" start_line="35" end_line="35" start_column="13" end_column="14" covered="yes" />
            <range source_id="8" start_line="36" end_line="36" start_column="17" end_column="54" covered="yes" />
            <range source_id="8" start_line="37" end_line="37" start_column="13" end_column="14" covered="yes" />
            <range source_id="8" start_line="38" end_line="38" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12884" token="0x600005b" name="Cancel(string)" namespace="HealthApp.Model" type_name="Appointment" block_coverage="100.00" line_coverage="100.00" blocks_covered="6" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="8" start_line="41" end_line="41" start_column="9" end_column="10" covered="yes" />
            <range source_id="8" start_line="42" end_line="42" start_column="13" end_column="55" covered="yes" />
            <range source_id="8" start_line="43" end_line="43" start_column="13" end_column="14" covered="yes" />
            <range source_id="8" start_line="44" end_line="44" start_column="17" end_column="54" covered="yes" />
            <range source_id="8" start_line="46" end_line="46" start_column="17" end_column="45" covered="yes" />
            <range source_id="8" start_line="47" end_line="47" start_column="13" end_column="14" covered="yes" />
            <range source_id="8" start_line="48" end_line="48" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12932" token="0x600005c" name="Complete()" namespace="HealthApp.Model" type_name="Appointment" block_coverage="100.00" line_coverage="100.00" blocks_covered="5" blocks_not_covered="0" lines_covered="6" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="8" start_line="51" end_line="51" start_column="9" end_column="10" covered="yes" />
            <range source_id="8" start_line="52" end_line="52" start_column="13" end_column="55" covered="yes" />
            <range source_id="8" start_line="53" end_line="53" start_column="13" end_column="14" covered="yes" />
            <range source_id="8" start_line="54" end_line="54" start_column="17" end_column="54" covered="yes" />
            <range source_id="8" start_line="55" end_line="55" start_column="13" end_column="14" covered="yes" />
            <range source_id="8" start_line="56" end_line="56" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="12972" token="0x600005d" name="GetDetails()" namespace="HealthApp.Model" type_name="Appointment" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="35" lines_covered="0" lines_partially_covered="0" lines_not_covered="10">
          <ranges>
            <range source_id="8" start_line="59" end_line="59" start_column="9" end_column="10" covered="no" />
            <range source_id="8" start_line="60" end_line="67" start_column="13" end_column="71" covered="no" />
            <range source_id="8" start_line="68" end_line="68" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="13298" token="0x600005e" name="Appointment()" namespace="HealthApp.Model" type_name="Appointment" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="8" start_line="19" end_line="19" start_column="48" end_column="56" covered="yes" />
            <range source_id="8" start_line="21" end_line="21" start_column="46" end_column="54" covered="yes" />
            <range source_id="8" start_line="25" end_line="25" start_column="48" end_column="60" covered="yes" />
            <range source_id="8" start_line="28" end_line="28" start_column="15" end_column="40" covered="yes" />
          </ranges>
        </function>
        <function id="13476" token="0x600006f" name="GetDoctorDetailsSummary()" namespace="HealthApp.Model" type_name="Doctor" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="32" lines_covered="0" lines_partially_covered="0" lines_not_covered="10">
          <ranges>
            <range source_id="9" start_line="37" end_line="37" start_column="9" end_column="10" covered="no" />
            <range source_id="9" start_line="38" end_line="45" start_column="13" end_column="62" covered="no" />
            <range source_id="9" start_line="47" end_line="47" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="13796" token="0x6000070" name="IsValidEmail()" namespace="HealthApp.Model" type_name="Doctor" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="5" lines_covered="0" lines_partially_covered="0" lines_not_covered="9">
          <ranges>
            <range source_id="9" start_line="49" end_line="49" start_column="9" end_column="10" covered="no" />
            <range source_id="9" start_line="50" end_line="50" start_column="13" end_column="60" covered="no" />
            <range source_id="9" start_line="51" end_line="56" start_column="13" end_column="6" covered="no" />
            <range source_id="9" start_line="57" end_line="57" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="13840" token="0x6000071" name="IsValidPhoneNumber()" namespace="HealthApp.Model" type_name="Doctor" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="5" lines_covered="0" lines_partially_covered="0" lines_not_covered="4">
          <ranges>
            <range source_id="9" start_line="59" end_line="59" start_column="9" end_column="10" covered="no" />
            <range source_id="9" start_line="60" end_line="60" start_column="13" end_column="45" covered="no" />
            <range source_id="9" start_line="61" end_line="61" start_column="13" end_column="102" covered="no" />
            <range source_id="9" start_line="62" end_line="62" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="13884" token="0x6000072" name="IsValidName()" namespace="HealthApp.Model" type_name="Doctor" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="9" lines_covered="0" lines_partially_covered="0" lines_not_covered="6">
          <ranges>
            <range source_id="9" start_line="64" end_line="64" start_column="9" end_column="10" covered="no" />
            <range source_id="9" start_line="65" end_line="65" start_column="13" end_column="53" covered="no" />
            <range source_id="9" start_line="66" end_line="66" start_column="17" end_column="30" covered="no" />
            <range source_id="9" start_line="68" end_line="68" start_column="13" end_column="56" covered="no" />
            <range source_id="9" start_line="69" end_line="69" start_column="13" end_column="97" covered="no" />
            <range source_id="9" start_line="70" end_line="70" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="13947" token="0x6000073" name="Doctor()" namespace="HealthApp.Model" type_name="Doctor" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="9" start_line="24" end_line="24" start_column="48" end_column="60" covered="yes" />
            <range source_id="9" start_line="27" end_line="27" start_column="53" end_column="65" covered="yes" />
            <range source_id="9" start_line="28" end_line="28" start_column="51" end_column="63" covered="yes" />
          </ranges>
        </function>
        <function id="14108" token="0x6000082" name="GetSummary()" namespace="HealthApp.Model" type_name="HealthRecord" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="29" lines_covered="0" lines_partially_covered="0" lines_not_covered="9">
          <ranges>
            <range source_id="10" start_line="24" end_line="24" start_column="9" end_column="10" covered="no" />
            <range source_id="10" start_line="25" end_line="31" start_column="13" end_column="35" covered="no" />
            <range source_id="10" start_line="32" end_line="32" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="14380" token="0x6000083" name="HealthRecord()" namespace="HealthApp.Model" type_name="HealthRecord" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="5" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="10" start_line="11" end_line="11" start_column="48" end_column="56" covered="yes" />
            <range source_id="10" start_line="13" end_line="13" start_column="46" end_column="54" covered="yes" />
            <range source_id="10" start_line="17" end_line="17" start_column="49" end_column="61" covered="yes" />
            <range source_id="10" start_line="19" end_line="19" start_column="52" end_column="64" covered="yes" />
            <range source_id="10" start_line="21" end_line="21" start_column="45" end_column="57" covered="yes" />
          </ranges>
        </function>
        <function id="14572" token="0x6000094" name="Patient()" namespace="HealthApp.Model" type_name="Patient" block_coverage="100.00" line_coverage="100.00" blocks_covered="4" blocks_not_covered="0" lines_covered="8" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="11" start_line="18" end_line="18" start_column="48" end_column="60" covered="yes" />
            <range source_id="11" start_line="24" end_line="24" start_column="51" end_column="63" covered="yes" />
            <range source_id="11" start_line="26" end_line="26" start_column="45" end_column="57" covered="yes" />
            <range source_id="11" start_line="28" end_line="28" start_column="51" end_column="63" covered="yes" />
            <range source_id="11" start_line="32" end_line="32" start_column="9" end_column="25" covered="yes" />
            <range source_id="11" start_line="33" end_line="33" start_column="9" end_column="10" covered="yes" />
            <range source_id="11" start_line="34" end_line="34" start_column="13" end_column="40" covered="yes" />
            <range source_id="11" start_line="35" end_line="35" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="14652" token="0x6000095" name="IsValidEmail()" namespace="HealthApp.Model" type_name="Patient" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="5" lines_covered="0" lines_partially_covered="0" lines_not_covered="9">
          <ranges>
            <range source_id="11" start_line="37" end_line="37" start_column="9" end_column="10" covered="no" />
            <range source_id="11" start_line="38" end_line="38" start_column="13" end_column="60" covered="no" />
            <range source_id="11" start_line="39" end_line="44" start_column="13" end_column="6" covered="no" />
            <range source_id="11" start_line="45" end_line="45" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="14696" token="0x6000096" name="IsValidPhoneNumber()" namespace="HealthApp.Model" type_name="Patient" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="5" lines_covered="0" lines_partially_covered="0" lines_not_covered="9">
          <ranges>
            <range source_id="11" start_line="47" end_line="47" start_column="9" end_column="10" covered="no" />
            <range source_id="11" start_line="48" end_line="48" start_column="13" end_column="45" covered="no" />
            <range source_id="11" start_line="49" end_line="54" start_column="13" end_column="6" covered="no" />
            <range source_id="11" start_line="55" end_line="55" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="14740" token="0x6000097" name="IsValidName()" namespace="HealthApp.Model" type_name="Patient" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="9" lines_covered="0" lines_partially_covered="0" lines_not_covered="11">
          <ranges>
            <range source_id="11" start_line="57" end_line="57" start_column="9" end_column="10" covered="no" />
            <range source_id="11" start_line="58" end_line="58" start_column="13" end_column="53" covered="no" />
            <range source_id="11" start_line="59" end_line="59" start_column="17" end_column="30" covered="no" />
            <range source_id="11" start_line="61" end_line="61" start_column="13" end_column="56" covered="no" />
            <range source_id="11" start_line="62" end_line="67" start_column="13" end_column="5" covered="no" />
            <range source_id="11" start_line="68" end_line="68" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="14804" token="0x6000098" name="GetAge()" namespace="HealthApp.Model" type_name="Patient" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="13" lines_covered="0" lines_partially_covered="0" lines_not_covered="8">
          <ranges>
            <range source_id="11" start_line="71" end_line="71" start_column="9" end_column="10" covered="no" />
            <range source_id="11" start_line="72" end_line="72" start_column="13" end_column="62" covered="no" />
            <range source_id="11" start_line="74" end_line="74" start_column="13" end_column="83" covered="no" />
            <range source_id="11" start_line="75" end_line="75" start_column="13" end_column="14" covered="no" />
            <range source_id="11" start_line="76" end_line="76" start_column="17" end_column="23" covered="no" />
            <range source_id="11" start_line="77" end_line="77" start_column="13" end_column="14" covered="no" />
            <range source_id="11" start_line="79" end_line="79" start_column="13" end_column="24" covered="no" />
            <range source_id="11" start_line="80" end_line="80" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="14896" token="0x6000099" name="GetProfileSummary()" namespace="HealthApp.Model" type_name="Patient" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="36" lines_covered="0" lines_partially_covered="0" lines_not_covered="11">
          <ranges>
            <range source_id="11" start_line="83" end_line="83" start_column="9" end_column="10" covered="no" />
            <range source_id="11" start_line="84" end_line="92" start_column="13" end_column="54" covered="no" />
            <range source_id="11" start_line="96" end_line="96" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="15254" token="0x600009a" name="DoctorMenu(HealthApp.Service.Interface.IDoctorService, HealthApp.Service.Interface.IAppointmentService, HealthApp.Service.Interface.IHealthRecordService)" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="12">
          <ranges>
            <range source_id="12" start_line="24" end_line="30" start_column="9" end_column="48" covered="no" />
            <range source_id="12" start_line="32" end_line="32" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="34" end_line="34" start_column="13" end_column="44" covered="no" />
            <range source_id="12" start_line="36" end_line="36" start_column="13" end_column="54" covered="no" />
            <range source_id="12" start_line="38" end_line="38" start_column="13" end_column="44" covered="no" />
            <range source_id="12" start_line="40" end_line="40" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="15288" token="0x600009b" name="Show()" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="41" lines_covered="0" lines_partially_covered="0" lines_not_covered="42">
          <ranges>
            <range source_id="12" start_line="44" end_line="44" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="48" end_line="48" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="50" end_line="50" start_column="17" end_column="33" covered="no" />
            <range source_id="12" start_line="53" end_line="53" start_column="17" end_column="79" covered="no" />
            <range source_id="12" start_line="54" end_line="54" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="55" end_line="55" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="56" end_line="56" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="57" end_line="57" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="58" end_line="58" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="59" end_line="59" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="60" end_line="60" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="61" end_line="61" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="62" end_line="62" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="63" end_line="63" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="64" end_line="64" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="65" end_line="65" start_column="17" end_column="79" covered="no" />
            <range source_id="12" start_line="68" end_line="68" start_column="17" end_column="45" covered="no" />
            <range source_id="12" start_line="70" end_line="70" start_column="17" end_column="49" covered="no" />
            <range source_id="12" start_line="72" end_line="72" start_column="17" end_column="32" covered="no" />
            <range source_id="12" start_line="78" end_line="78" start_column="25" end_column="37" covered="no" />
            <range source_id="12" start_line="80" end_line="80" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="85" end_line="85" start_column="25" end_column="46" covered="no" />
            <range source_id="12" start_line="87" end_line="87" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="92" end_line="92" start_column="25" end_column="51" covered="no" />
            <range source_id="12" start_line="94" end_line="94" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="98" end_line="98" start_column="25" end_column="46" covered="no" />
            <range source_id="12" start_line="100" end_line="100" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="104" end_line="104" start_column="25" end_column="45" covered="no" />
            <range source_id="12" start_line="105" end_line="105" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="110" end_line="110" start_column="25" end_column="52" covered="no" />
            <range source_id="12" start_line="112" end_line="112" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="116" end_line="116" start_column="25" end_column="43" covered="no" />
            <range source_id="12" start_line="118" end_line="118" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="124" end_line="124" start_column="25" end_column="51" covered="no" />
            <range source_id="12" start_line="126" end_line="126" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="132" end_line="132" start_column="25" end_column="32" covered="no" />
            <range source_id="12" start_line="136" end_line="136" start_column="25" end_column="62" covered="no" />
            <range source_id="12" start_line="138" end_line="138" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="140" end_line="140" start_column="17" end_column="25" covered="no" />
            <range source_id="12" start_line="141" end_line="141" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="46" end_line="46" start_column="13" end_column="25" covered="no" />
            <range source_id="12" start_line="142" end_line="142" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="15888" token="0x600009c" name="AddDoctor()" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="32" lines_covered="0" lines_partially_covered="0" lines_not_covered="50">
          <ranges>
            <range source_id="12" start_line="144" end_line="144" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="146" end_line="146" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="147" end_line="147" start_column="17" end_column="59" covered="no" />
            <range source_id="12" start_line="149" end_line="187" start_column="17" end_column="19" covered="no" />
            <range source_id="12" start_line="189" end_line="189" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="190" end_line="190" start_column="17" end_column="64" covered="no" />
            <range source_id="12" start_line="191" end_line="191" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="192" end_line="192" start_column="13" end_column="33" covered="no" />
            <range source_id="12" start_line="193" end_line="193" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="194" end_line="194" start_column="17" end_column="59" covered="no" />
            <range source_id="12" start_line="195" end_line="195" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="196" end_line="196" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="16220" token="0x600009d" name="ReadValidInput(string, System.Func&lt;string, bool&gt;, string)" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="10" lines_covered="0" lines_partially_covered="0" lines_not_covered="10">
          <ranges>
            <range source_id="12" start_line="201" end_line="201" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="203" end_line="203" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="204" end_line="204" start_column="17" end_column="40" covered="no" />
            <range source_id="12" start_line="206" end_line="206" start_column="17" end_column="52" covered="no" />
            <range source_id="12" start_line="208" end_line="208" start_column="17" end_column="38" covered="no" />
            <range source_id="12" start_line="209" end_line="209" start_column="21" end_column="34" covered="no" />
            <range source_id="12" start_line="211" end_line="211" start_column="17" end_column="49" covered="no" />
            <range source_id="12" start_line="212" end_line="212" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="202" end_line="202" start_column="13" end_column="25" covered="no" />
            <range source_id="12" start_line="213" end_line="213" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="16280" token="0x600009e" name="ReadInt(string, string, int, int)" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="21" lines_covered="0" lines_partially_covered="0" lines_not_covered="9">
          <ranges>
            <range source_id="12" start_line="217" end_line="217" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="219" end_line="219" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="220" end_line="220" start_column="17" end_column="40" covered="no" />
            <range source_id="12" start_line="222" end_line="222" start_column="17" end_column="101" covered="no" />
            <range source_id="12" start_line="223" end_line="223" start_column="21" end_column="34" covered="no" />
            <range source_id="12" start_line="225" end_line="225" start_column="17" end_column="91" covered="no" />
            <range source_id="12" start_line="226" end_line="226" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="218" end_line="218" start_column="13" end_column="25" covered="no" />
            <range source_id="12" start_line="227" end_line="227" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="16424" token="0x600009f" name="ReadDecimal(string, string)" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="14" lines_covered="0" lines_partially_covered="0" lines_not_covered="9">
          <ranges>
            <range source_id="12" start_line="230" end_line="230" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="232" end_line="232" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="233" end_line="233" start_column="17" end_column="40" covered="no" />
            <range source_id="12" start_line="235" end_line="235" start_column="17" end_column="90" covered="no" />
            <range source_id="12" start_line="236" end_line="236" start_column="21" end_column="34" covered="no" />
            <range source_id="12" start_line="238" end_line="238" start_column="17" end_column="49" covered="no" />
            <range source_id="12" start_line="239" end_line="239" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="231" end_line="231" start_column="13" end_column="25" covered="no" />
            <range source_id="12" start_line="240" end_line="240" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="16500" token="0x60000a0" name="ReadSpecialisation()" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="26" lines_covered="0" lines_partially_covered="0" lines_not_covered="17">
          <ranges>
            <range source_id="12" start_line="243" end_line="243" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="245" end_line="245" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="246" end_line="246" start_column="17" end_column="61" covered="no" />
            <range source_id="12" start_line="248" end_line="248" start_column="17" end_column="24" covered="no" />
            <range source_id="12" start_line="248" end_line="248" start_column="38" end_column="74" covered="no" />
            <range source_id="12" start_line="248" end_line="248" start_column="26" end_column="34" covered="no" />
            <range source_id="12" start_line="249" end_line="249" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="250" end_line="250" start_column="21" end_column="63" covered="no" />
            <range source_id="12" start_line="251" end_line="251" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="248" end_line="248" start_column="35" end_column="37" covered="no" />
            <range source_id="12" start_line="253" end_line="253" start_column="17" end_column="43" covered="no" />
            <range source_id="12" start_line="254" end_line="254" start_column="17" end_column="52" covered="no" />
            <range source_id="12" start_line="256" end_line="257" start_column="17" end_column="74" covered="no" />
            <range source_id="12" start_line="258" end_line="258" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="259" end_line="259" start_column="21" end_column="54" covered="no" />
            <range source_id="12" start_line="262" end_line="262" start_column="17" end_column="80" covered="no" />
            <range source_id="12" start_line="263" end_line="263" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="244" end_line="244" start_column="13" end_column="25" covered="no" />
            <range source_id="12" start_line="264" end_line="264" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="16700" token="0x60000a1" name="AddHealthRecord()" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="53" lines_covered="0" lines_partially_covered="0" lines_not_covered="55">
          <ranges>
            <range source_id="12" start_line="268" end_line="268" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="270" end_line="270" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="274" end_line="278" start_column="17" end_column="19" covered="no" />
            <range source_id="12" start_line="280" end_line="280" start_column="17" end_column="39" covered="no" />
            <range source_id="12" start_line="283" end_line="283" start_column="17" end_column="78" covered="no" />
            <range source_id="12" start_line="285" end_line="285" start_column="17" end_column="41" covered="no" />
            <range source_id="12" start_line="286" end_line="286" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="287" end_line="287" start_column="21" end_column="64" covered="no" />
            <range source_id="12" start_line="288" end_line="288" start_column="21" end_column="28" covered="no" />
            <range source_id="12" start_line="291" end_line="291" start_column="17" end_column="71" covered="no" />
            <range source_id="12" start_line="292" end_line="292" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="293" end_line="293" start_column="21" end_column="96" covered="no" />
            <range source_id="12" start_line="294" end_line="294" start_column="21" end_column="28" covered="no" />
            <range source_id="12" start_line="297" end_line="297" start_column="17" end_column="69" covered="no" />
            <range source_id="12" start_line="298" end_line="298" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="299" end_line="299" start_column="21" end_column="101" covered="no" />
            <range source_id="12" start_line="300" end_line="300" start_column="21" end_column="28" covered="no" />
            <range source_id="12" start_line="303" end_line="303" start_column="17" end_column="71" covered="no" />
            <range source_id="12" start_line="304" end_line="304" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="305" end_line="305" start_column="21" end_column="92" covered="no" />
            <range source_id="12" start_line="306" end_line="306" start_column="21" end_column="28" covered="no" />
            <range source_id="12" start_line="309" end_line="314" start_column="17" end_column="19" covered="no" />
            <range source_id="12" start_line="316" end_line="320" start_column="17" end_column="19" covered="no" />
            <range source_id="12" start_line="322" end_line="326" start_column="17" end_column="19" covered="no" />
            <range source_id="12" start_line="328" end_line="332" start_column="17" end_column="19" covered="no" />
            <range source_id="12" start_line="334" end_line="334" start_column="17" end_column="50" covered="no" />
            <range source_id="12" start_line="336" end_line="336" start_column="17" end_column="40" covered="no" />
            <range source_id="12" start_line="338" end_line="338" start_column="17" end_column="58" covered="no" />
            <range source_id="12" start_line="339" end_line="339" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="340" end_line="340" start_column="13" end_column="33" covered="no" />
            <range source_id="12" start_line="341" end_line="341" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="342" end_line="342" start_column="17" end_column="59" covered="no" />
            <range source_id="12" start_line="343" end_line="343" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="344" end_line="344" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="17200" token="0x60000a2" name="ConfirmAppointment()" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="26" lines_covered="0" lines_partially_covered="0" lines_not_covered="30">
          <ranges>
            <range source_id="12" start_line="348" end_line="348" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="350" end_line="350" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="353" end_line="353" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="354" end_line="354" start_column="21" end_column="55" covered="no" />
            <range source_id="12" start_line="356" end_line="356" start_column="21" end_column="56" covered="no" />
            <range source_id="12" start_line="358" end_line="358" start_column="21" end_column="53" covered="no" />
            <range source_id="12" start_line="359" end_line="359" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="361" end_line="361" start_column="21" end_column="56" covered="no" />
            <range source_id="12" start_line="362" end_line="362" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="352" end_line="352" start_column="17" end_column="29" covered="no" />
            <range source_id="12" start_line="364" end_line="364" start_column="17" end_column="60" covered="no" />
            <range source_id="12" start_line="366" end_line="366" start_column="17" end_column="61" covered="no" />
            <range source_id="12" start_line="367" end_line="367" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="368" end_line="368" start_column="13" end_column="52" covered="no" />
            <range source_id="12" start_line="369" end_line="369" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="370" end_line="370" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="371" end_line="371" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="372" end_line="372" start_column="13" end_column="60" covered="no" />
            <range source_id="12" start_line="373" end_line="373" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="374" end_line="374" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="375" end_line="375" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="376" end_line="376" start_column="13" end_column="60" covered="no" />
            <range source_id="12" start_line="377" end_line="377" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="378" end_line="378" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="379" end_line="379" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="380" end_line="380" start_column="13" end_column="60" covered="no" />
            <range source_id="12" start_line="381" end_line="381" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="382" end_line="382" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="383" end_line="383" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="384" end_line="384" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="17420" token="0x60000a3" name="ChangeDoctorStatus()" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="30" lines_covered="0" lines_partially_covered="0" lines_not_covered="34">
          <ranges>
            <range source_id="12" start_line="387" end_line="387" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="389" end_line="389" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="392" end_line="392" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="393" end_line="393" start_column="21" end_column="51" covered="no" />
            <range source_id="12" start_line="395" end_line="395" start_column="21" end_column="62" covered="no" />
            <range source_id="12" start_line="397" end_line="397" start_column="21" end_column="59" covered="no" />
            <range source_id="12" start_line="398" end_line="398" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="400" end_line="400" start_column="21" end_column="56" covered="no" />
            <range source_id="12" start_line="401" end_line="401" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="391" end_line="391" start_column="17" end_column="29" covered="no" />
            <range source_id="12" start_line="406" end_line="406" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="407" end_line="407" start_column="21" end_column="57" covered="no" />
            <range source_id="12" start_line="409" end_line="411" start_column="21" end_column="36" covered="no" />
            <range source_id="12" start_line="413" end_line="413" start_column="21" end_column="40" covered="no" />
            <range source_id="12" start_line="414" end_line="414" start_column="21" end_column="22" covered="no" />
            <range source_id="12" start_line="415" end_line="415" start_column="25" end_column="41" covered="no" />
            <range source_id="12" start_line="416" end_line="416" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="419" end_line="419" start_column="21" end_column="39" covered="no" />
            <range source_id="12" start_line="420" end_line="420" start_column="21" end_column="22" covered="no" />
            <range source_id="12" start_line="421" end_line="421" start_column="25" end_column="42" covered="no" />
            <range source_id="12" start_line="422" end_line="422" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="425" end_line="425" start_column="21" end_column="71" covered="no" />
            <range source_id="12" start_line="426" end_line="426" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="405" end_line="405" start_column="17" end_column="29" covered="no" />
            <range source_id="12" start_line="428" end_line="428" start_column="17" end_column="81" covered="no" />
            <range source_id="12" start_line="430" end_line="430" start_column="17" end_column="43" covered="no" />
            <range source_id="12" start_line="431" end_line="431" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="432" end_line="432" start_column="13" end_column="47" covered="no" />
            <range source_id="12" start_line="433" end_line="433" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="434" end_line="434" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="435" end_line="435" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="436" end_line="436" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="17644" token="0x60000a4" name="ViewPatientHealthRecord()" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="25" lines_covered="0" lines_partially_covered="0" lines_not_covered="21">
          <ranges>
            <range source_id="12" start_line="439" end_line="439" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="441" end_line="441" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="444" end_line="444" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="445" end_line="445" start_column="21" end_column="51" covered="no" />
            <range source_id="12" start_line="447" end_line="447" start_column="21" end_column="56" covered="no" />
            <range source_id="12" start_line="449" end_line="449" start_column="21" end_column="53" covered="no" />
            <range source_id="12" start_line="450" end_line="450" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="452" end_line="452" start_column="21" end_column="56" covered="no" />
            <range source_id="12" start_line="453" end_line="453" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="443" end_line="443" start_column="17" end_column="29" covered="no" />
            <range source_id="12" start_line="455" end_line="455" start_column="17" end_column="68" covered="no" />
            <range source_id="12" start_line="457" end_line="457" start_column="17" end_column="24" covered="no" />
            <range source_id="12" start_line="457" end_line="457" start_column="35" end_column="42" covered="no" />
            <range source_id="12" start_line="457" end_line="457" start_column="26" end_column="31" covered="no" />
            <range source_id="12" start_line="458" end_line="458" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="459" end_line="459" start_column="21" end_column="55" covered="no" />
            <range source_id="12" start_line="460" end_line="460" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="457" end_line="457" start_column="32" end_column="34" covered="no" />
            <range source_id="12" start_line="461" end_line="461" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="462" end_line="462" start_column="13" end_column="56" covered="no" />
            <range source_id="12" start_line="463" end_line="463" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="464" end_line="464" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="465" end_line="465" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="466" end_line="466" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="17836" token="0x60000a5" name="ViewUpcomingAppointments()" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="28" lines_covered="0" lines_partially_covered="0" lines_not_covered="25">
          <ranges>
            <range source_id="12" start_line="469" end_line="469" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="471" end_line="471" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="475" end_line="475" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="476" end_line="476" start_column="21" end_column="51" covered="no" />
            <range source_id="12" start_line="478" end_line="478" start_column="21" end_column="56" covered="no" />
            <range source_id="12" start_line="480" end_line="480" start_column="21" end_column="53" covered="no" />
            <range source_id="12" start_line="481" end_line="481" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="483" end_line="483" start_column="21" end_column="56" covered="no" />
            <range source_id="12" start_line="484" end_line="484" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="474" end_line="474" start_column="17" end_column="29" covered="no" />
            <range source_id="12" start_line="486" end_line="490" start_column="17" end_column="53" covered="no" />
            <range source_id="12" start_line="492" end_line="492" start_column="17" end_column="24" covered="no" />
            <range source_id="12" start_line="492" end_line="492" start_column="35" end_column="39" covered="no" />
            <range source_id="12" start_line="492" end_line="492" start_column="26" end_column="31" covered="no" />
            <range source_id="12" start_line="493" end_line="493" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="494" end_line="494" start_column="21" end_column="55" covered="no" />
            <range source_id="12" start_line="495" end_line="495" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="492" end_line="492" start_column="32" end_column="34" covered="no" />
            <range source_id="12" start_line="496" end_line="496" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="497" end_line="497" start_column="13" end_column="33" covered="no" />
            <range source_id="12" start_line="498" end_line="498" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="499" end_line="499" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="500" end_line="500" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="501" end_line="501" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="18056" token="0x60000a6" name="ViewPendingAppointments()" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="25" lines_covered="0" lines_partially_covered="0" lines_not_covered="22">
          <ranges>
            <range source_id="12" start_line="504" end_line="504" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="506" end_line="506" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="510" end_line="510" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="511" end_line="511" start_column="21" end_column="51" covered="no" />
            <range source_id="12" start_line="513" end_line="513" start_column="21" end_column="56" covered="no" />
            <range source_id="12" start_line="515" end_line="515" start_column="21" end_column="53" covered="no" />
            <range source_id="12" start_line="516" end_line="516" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="518" end_line="518" start_column="21" end_column="56" covered="no" />
            <range source_id="12" start_line="519" end_line="519" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="509" end_line="509" start_column="17" end_column="29" covered="no" />
            <range source_id="12" start_line="521" end_line="522" start_column="17" end_column="57" covered="no" />
            <range source_id="12" start_line="524" end_line="524" start_column="17" end_column="24" covered="no" />
            <range source_id="12" start_line="524" end_line="524" start_column="35" end_column="39" covered="no" />
            <range source_id="12" start_line="524" end_line="524" start_column="26" end_column="31" covered="no" />
            <range source_id="12" start_line="525" end_line="525" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="526" end_line="526" start_column="21" end_column="55" covered="no" />
            <range source_id="12" start_line="527" end_line="527" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="524" end_line="524" start_column="32" end_column="34" covered="no" />
            <range source_id="12" start_line="528" end_line="528" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="529" end_line="529" start_column="13" end_column="52" covered="no" />
            <range source_id="12" start_line="530" end_line="530" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="531" end_line="531" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="532" end_line="532" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="534" end_line="534" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="18248" token="0x60000a7" name="CancelAppointment()" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="31" lines_covered="0" lines_partially_covered="0" lines_not_covered="34">
          <ranges>
            <range source_id="12" start_line="537" end_line="537" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="539" end_line="539" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="543" end_line="543" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="544" end_line="544" start_column="21" end_column="55" covered="no" />
            <range source_id="12" start_line="546" end_line="546" start_column="21" end_column="56" covered="no" />
            <range source_id="12" start_line="548" end_line="548" start_column="21" end_column="53" covered="no" />
            <range source_id="12" start_line="549" end_line="549" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="551" end_line="551" start_column="21" end_column="56" covered="no" />
            <range source_id="12" start_line="552" end_line="552" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="542" end_line="542" start_column="17" end_column="29" covered="no" />
            <range source_id="12" start_line="557" end_line="557" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="558" end_line="558" start_column="21" end_column="47" covered="no" />
            <range source_id="12" start_line="560" end_line="560" start_column="21" end_column="50" covered="no" />
            <range source_id="12" start_line="562" end_line="562" start_column="21" end_column="60" covered="no" />
            <range source_id="12" start_line="563" end_line="563" start_column="25" end_column="31" covered="no" />
            <range source_id="12" start_line="565" end_line="565" start_column="21" end_column="66" covered="no" />
            <range source_id="12" start_line="566" end_line="566" start_column="17" end_column="18" covered="no" />
            <range source_id="12" start_line="556" end_line="556" start_column="17" end_column="29" covered="no" />
            <range source_id="12" start_line="568" end_line="568" start_column="17" end_column="67" covered="no" />
            <range source_id="12" start_line="570" end_line="570" start_column="17" end_column="61" covered="no" />
            <range source_id="12" start_line="571" end_line="571" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="572" end_line="572" start_column="13" end_column="60" covered="no" />
            <range source_id="12" start_line="573" end_line="573" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="574" end_line="574" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="575" end_line="575" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="576" end_line="576" start_column="13" end_column="60" covered="no" />
            <range source_id="12" start_line="577" end_line="577" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="578" end_line="578" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="579" end_line="579" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="580" end_line="580" start_column="13" end_column="52" covered="no" />
            <range source_id="12" start_line="581" end_line="581" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="582" end_line="582" start_column="17" end_column="47" covered="no" />
            <range source_id="12" start_line="583" end_line="583" start_column="13" end_column="14" covered="no" />
            <range source_id="12" start_line="584" end_line="584" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="18496" token="0x60000a8" name="Pause()" namespace="HealthApp.Menus" type_name="DoctorMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="3" lines_covered="0" lines_partially_covered="0" lines_not_covered="4">
          <ranges>
            <range source_id="12" start_line="586" end_line="586" start_column="9" end_column="10" covered="no" />
            <range source_id="12" start_line="587" end_line="587" start_column="13" end_column="53" covered="no" />
            <range source_id="12" start_line="588" end_line="588" start_column="13" end_column="31" covered="no" />
            <range source_id="12" start_line="589" end_line="589" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="18516" token="0x60000a9" name="PatientMenu(HealthApp.Service.Interface.IPatientService, HealthApp.Service.Interface.IDoctorService, HealthApp.Service.Interface.IAppointmentService, HealthApp.Service.Interface.IHealthRecordService)" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="11">
          <ranges>
            <range source_id="13" start_line="20" end_line="24" start_column="9" end_column="48" covered="no" />
            <range source_id="13" start_line="25" end_line="25" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="26" end_line="26" start_column="13" end_column="46" covered="no" />
            <range source_id="13" start_line="27" end_line="27" start_column="13" end_column="44" covered="no" />
            <range source_id="13" start_line="28" end_line="28" start_column="13" end_column="54" covered="no" />
            <range source_id="13" start_line="29" end_line="29" start_column="13" end_column="44" covered="no" />
            <range source_id="13" start_line="30" end_line="30" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="18556" token="0x60000aa" name="Show()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="41" lines_covered="0" lines_partially_covered="0" lines_not_covered="42">
          <ranges>
            <range source_id="13" start_line="33" end_line="33" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="35" end_line="35" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="36" end_line="36" start_column="17" end_column="33" covered="no" />
            <range source_id="13" start_line="38" end_line="38" start_column="17" end_column="87" covered="no" />
            <range source_id="13" start_line="39" end_line="39" start_column="17" end_column="88" covered="no" />
            <range source_id="13" start_line="40" end_line="40" start_column="17" end_column="88" covered="no" />
            <range source_id="13" start_line="41" end_line="41" start_column="17" end_column="88" covered="no" />
            <range source_id="13" start_line="42" end_line="42" start_column="17" end_column="88" covered="no" />
            <range source_id="13" start_line="43" end_line="43" start_column="17" end_column="88" covered="no" />
            <range source_id="13" start_line="44" end_line="44" start_column="17" end_column="88" covered="no" />
            <range source_id="13" start_line="45" end_line="45" start_column="17" end_column="88" covered="no" />
            <range source_id="13" start_line="46" end_line="46" start_column="17" end_column="88" covered="no" />
            <range source_id="13" start_line="47" end_line="47" start_column="17" end_column="88" covered="no" />
            <range source_id="13" start_line="48" end_line="48" start_column="17" end_column="88" covered="no" />
            <range source_id="13" start_line="49" end_line="49" start_column="17" end_column="88" covered="no" />
            <range source_id="13" start_line="50" end_line="50" start_column="17" end_column="87" covered="no" />
            <range source_id="13" start_line="53" end_line="53" start_column="17" end_column="45" covered="no" />
            <range source_id="13" start_line="54" end_line="54" start_column="17" end_column="49" covered="no" />
            <range source_id="13" start_line="56" end_line="56" start_column="17" end_column="32" covered="no" />
            <range source_id="13" start_line="59" end_line="59" start_column="25" end_column="43" covered="no" />
            <range source_id="13" start_line="60" end_line="60" start_column="25" end_column="31" covered="no" />
            <range source_id="13" start_line="63" end_line="63" start_column="25" end_column="41" covered="no" />
            <range source_id="13" start_line="64" end_line="64" start_column="25" end_column="31" covered="no" />
            <range source_id="13" start_line="67" end_line="67" start_column="25" end_column="41" covered="no" />
            <range source_id="13" start_line="68" end_line="68" start_column="25" end_column="31" covered="no" />
            <range source_id="13" start_line="71" end_line="71" start_column="25" end_column="43" covered="no" />
            <range source_id="13" start_line="72" end_line="72" start_column="25" end_column="31" covered="no" />
            <range source_id="13" start_line="75" end_line="75" start_column="25" end_column="45" covered="no" />
            <range source_id="13" start_line="76" end_line="76" start_column="25" end_column="31" covered="no" />
            <range source_id="13" start_line="79" end_line="79" start_column="25" end_column="44" covered="no" />
            <range source_id="13" start_line="80" end_line="80" start_column="25" end_column="31" covered="no" />
            <range source_id="13" start_line="83" end_line="83" start_column="25" end_column="45" covered="no" />
            <range source_id="13" start_line="84" end_line="84" start_column="25" end_column="31" covered="no" />
            <range source_id="13" start_line="87" end_line="87" start_column="25" end_column="51" covered="no" />
            <range source_id="13" start_line="88" end_line="88" start_column="25" end_column="31" covered="no" />
            <range source_id="13" start_line="91" end_line="91" start_column="25" end_column="32" covered="no" />
            <range source_id="13" start_line="94" end_line="94" start_column="25" end_column="80" covered="no" />
            <range source_id="13" start_line="95" end_line="95" start_column="25" end_column="31" covered="no" />
            <range source_id="13" start_line="97" end_line="97" start_column="17" end_column="25" covered="no" />
            <range source_id="13" start_line="98" end_line="98" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="34" end_line="34" start_column="13" end_column="25" covered="no" />
            <range source_id="13" start_line="99" end_line="99" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="19156" token="0x60000ab" name="RegisterPatient()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="12" lines_covered="0" lines_partially_covered="0" lines_not_covered="13">
          <ranges>
            <range source_id="13" start_line="102" end_line="102" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="104" end_line="104" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="105" end_line="105" start_column="17" end_column="65" covered="no" />
            <range source_id="13" start_line="107" end_line="107" start_column="17" end_column="59" covered="no" />
            <range source_id="13" start_line="109" end_line="109" start_column="17" end_column="58" covered="no" />
            <range source_id="13" start_line="111" end_line="111" start_column="17" end_column="72" covered="no" />
            <range source_id="13" start_line="112" end_line="112" start_column="17" end_column="64" covered="no" />
            <range source_id="13" start_line="113" end_line="113" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="114" end_line="114" start_column="13" end_column="43" covered="no" />
            <range source_id="13" start_line="115" end_line="115" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="116" end_line="116" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="117" end_line="117" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="118" end_line="118" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="19260" token="0x60000ac" name="Pause()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="3" lines_covered="0" lines_partially_covered="0" lines_not_covered="4">
          <ranges>
            <range source_id="13" start_line="121" end_line="121" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="122" end_line="122" start_column="13" end_column="53" covered="no" />
            <range source_id="13" start_line="123" end_line="123" start_column="13" end_column="31" covered="no" />
            <range source_id="13" start_line="125" end_line="125" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="19280" token="0x60000ad" name="ViewHealthHistory()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="21" lines_covered="0" lines_partially_covered="0" lines_not_covered="18">
          <ranges>
            <range source_id="13" start_line="128" end_line="128" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="130" end_line="130" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="131" end_line="131" start_column="17" end_column="51" covered="no" />
            <range source_id="13" start_line="133" end_line="133" start_column="17" end_column="69" covered="no" />
            <range source_id="13" start_line="135" end_line="135" start_column="17" end_column="40" covered="no" />
            <range source_id="13" start_line="136" end_line="136" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="137" end_line="137" start_column="21" end_column="67" covered="no" />
            <range source_id="13" start_line="138" end_line="138" start_column="21" end_column="28" covered="no" />
            <range source_id="13" start_line="141" end_line="141" start_column="17" end_column="24" covered="no" />
            <range source_id="13" start_line="141" end_line="141" start_column="35" end_column="42" covered="no" />
            <range source_id="13" start_line="141" end_line="141" start_column="26" end_column="31" covered="no" />
            <range source_id="13" start_line="142" end_line="142" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="143" end_line="143" start_column="21" end_column="55" covered="no" />
            <range source_id="13" start_line="144" end_line="144" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="141" end_line="141" start_column="32" end_column="34" covered="no" />
            <range source_id="13" start_line="145" end_line="145" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="146" end_line="146" start_column="13" end_column="56" covered="no" />
            <range source_id="13" start_line="147" end_line="147" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="148" end_line="148" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="149" end_line="149" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="152" end_line="152" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="19456" token="0x60000ae" name="ViewAppointments()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="23" lines_covered="0" lines_partially_covered="0" lines_not_covered="25">
          <ranges>
            <range source_id="13" start_line="155" end_line="155" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="157" end_line="157" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="159" end_line="159" start_column="17" end_column="51" covered="no" />
            <range source_id="13" start_line="162" end_line="164" start_column="17" end_column="52" covered="no" />
            <range source_id="13" start_line="166" end_line="166" start_column="17" end_column="45" covered="no" />
            <range source_id="13" start_line="167" end_line="167" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="168" end_line="169" start_column="21" end_column="60" covered="no" />
            <range source_id="13" start_line="170" end_line="170" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="172" end_line="172" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="173" end_line="173" start_column="21" end_column="28" covered="no" />
            <range source_id="13" start_line="173" end_line="173" start_column="39" end_column="51" covered="no" />
            <range source_id="13" start_line="173" end_line="173" start_column="30" end_column="35" covered="no" />
            <range source_id="13" start_line="174" end_line="174" start_column="21" end_column="22" covered="no" />
            <range source_id="13" start_line="175" end_line="175" start_column="25" end_column="59" covered="no" />
            <range source_id="13" start_line="177" end_line="178" start_column="25" end_column="48" covered="no" />
            <range source_id="13" start_line="179" end_line="179" start_column="21" end_column="22" covered="no" />
            <range source_id="13" start_line="173" end_line="173" start_column="36" end_column="38" covered="no" />
            <range source_id="13" start_line="180" end_line="180" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="181" end_line="181" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="182" end_line="182" start_column="13" end_column="52" covered="no" />
            <range source_id="13" start_line="183" end_line="183" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="184" end_line="184" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="185" end_line="185" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="186" end_line="186" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="19648" token="0x60000af" name="CancelAppointment()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="17" lines_covered="0" lines_partially_covered="0" lines_not_covered="26">
          <ranges>
            <range source_id="13" start_line="191" end_line="191" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="193" end_line="193" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="195" end_line="195" start_column="17" end_column="65" covered="no" />
            <range source_id="13" start_line="198" end_line="198" start_column="17" end_column="43" covered="no" />
            <range source_id="13" start_line="200" end_line="201" start_column="17" end_column="41" covered="no" />
            <range source_id="13" start_line="203" end_line="206" start_column="17" end_column="33" covered="no" />
            <range source_id="13" start_line="208" end_line="209" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="211" end_line="211" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="212" end_line="212" start_column="13" end_column="52" covered="no" />
            <range source_id="13" start_line="213" end_line="213" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="214" end_line="214" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="215" end_line="215" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="216" end_line="216" start_column="13" end_column="60" covered="no" />
            <range source_id="13" start_line="217" end_line="217" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="218" end_line="218" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="219" end_line="219" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="220" end_line="220" start_column="13" end_column="60" covered="no" />
            <range source_id="13" start_line="221" end_line="221" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="222" end_line="222" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="223" end_line="223" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="226" end_line="226" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="19812" token="0x60000b0" name="BookAppointment()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="65" lines_covered="0" lines_partially_covered="0" lines_not_covered="81">
          <ranges>
            <range source_id="13" start_line="228" end_line="228" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="232" end_line="232" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="235" end_line="235" start_column="17" end_column="57" covered="no" />
            <range source_id="13" start_line="238" end_line="240" start_column="17" end_column="48" covered="no" />
            <range source_id="13" start_line="243" end_line="243" start_column="17" end_column="77" covered="no" />
            <range source_id="13" start_line="244" end_line="244" start_column="17" end_column="33" covered="no" />
            <range source_id="13" start_line="247" end_line="247" start_column="17" end_column="55" covered="no" />
            <range source_id="13" start_line="249" end_line="251" start_column="17" end_column="46" covered="no" />
            <range source_id="13" start_line="254" end_line="254" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="255" end_line="255" start_column="21" end_column="70" covered="no" />
            <range source_id="13" start_line="257" end_line="257" start_column="21" end_column="56" covered="no" />
            <range source_id="13" start_line="259" end_line="264" start_column="21" end_column="39" covered="no" />
            <range source_id="13" start_line="265" end_line="265" start_column="21" end_column="22" covered="no" />
            <range source_id="13" start_line="266" end_line="266" start_column="25" end_column="82" covered="no" />
            <range source_id="13" start_line="267" end_line="267" start_column="25" end_column="34" covered="no" />
            <range source_id="13" start_line="271" end_line="271" start_column="21" end_column="52" covered="no" />
            <range source_id="13" start_line="272" end_line="272" start_column="21" end_column="22" covered="no" />
            <range source_id="13" start_line="273" end_line="274" start_column="25" end_column="72" covered="no" />
            <range source_id="13" start_line="275" end_line="275" start_column="25" end_column="34" covered="no" />
            <range source_id="13" start_line="277" end_line="277" start_column="21" end_column="64" covered="no" />
            <range source_id="13" start_line="278" end_line="278" start_column="21" end_column="22" covered="no" />
            <range source_id="13" start_line="279" end_line="279" start_column="25" end_column="98" covered="no" />
            <range source_id="13" start_line="280" end_line="280" start_column="21" end_column="22" covered="no" />
            <range source_id="13" start_line="282" end_line="282" start_column="21" end_column="27" covered="no" />
            <range source_id="13" start_line="253" end_line="253" start_column="17" end_column="29" covered="no" />
            <range source_id="13" start_line="287" end_line="287" start_column="17" end_column="42" covered="no" />
            <range source_id="13" start_line="289" end_line="295" start_column="17" end_column="31" covered="no" />
            <range source_id="13" start_line="297" end_line="298" start_column="17" end_column="60" covered="no" />
            <range source_id="13" start_line="300" end_line="301" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="302" end_line="302" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="303" end_line="303" start_column="13" end_column="41" covered="no" />
            <range source_id="13" start_line="304" end_line="304" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="305" end_line="306" start_column="17" end_column="45" covered="no" />
            <range source_id="13" start_line="307" end_line="307" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="308" end_line="308" start_column="13" end_column="50" covered="no" />
            <range source_id="13" start_line="309" end_line="309" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="310" end_line="311" start_column="17" end_column="45" covered="no" />
            <range source_id="13" start_line="312" end_line="312" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="313" end_line="313" start_column="13" end_column="48" covered="no" />
            <range source_id="13" start_line="314" end_line="314" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="315" end_line="316" start_column="17" end_column="45" covered="no" />
            <range source_id="13" start_line="317" end_line="317" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="318" end_line="318" start_column="13" end_column="52" covered="no" />
            <range source_id="13" start_line="319" end_line="319" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="320" end_line="321" start_column="17" end_column="45" covered="no" />
            <range source_id="13" start_line="322" end_line="322" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="323" end_line="323" start_column="13" end_column="48" covered="no" />
            <range source_id="13" start_line="324" end_line="324" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="325" end_line="325" start_column="17" end_column="59" covered="no" />
            <range source_id="13" start_line="326" end_line="326" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="327" end_line="327" start_column="13" end_column="47" covered="no" />
            <range source_id="13" start_line="328" end_line="328" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="329" end_line="329" start_column="17" end_column="59" covered="no" />
            <range source_id="13" start_line="330" end_line="330" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="331" end_line="331" start_column="13" end_column="49" covered="no" />
            <range source_id="13" start_line="332" end_line="332" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="333" end_line="333" start_column="17" end_column="58" covered="no" />
            <range source_id="13" start_line="334" end_line="334" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="336" end_line="336" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="20500" token="0x60000b1" name="ReadSlot()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="27" lines_covered="0" lines_partially_covered="0" lines_not_covered="18">
          <ranges>
            <range source_id="13" start_line="339" end_line="339" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="340" end_line="340" start_column="13" end_column="53" covered="no" />
            <range source_id="13" start_line="342" end_line="342" start_column="18" end_column="27" covered="no" />
            <range source_id="13" start_line="343" end_line="343" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="344" end_line="345" start_column="17" end_column="55" covered="no" />
            <range source_id="13" start_line="346" end_line="346" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="342" end_line="342" start_column="56" end_column="59" covered="no" />
            <range source_id="13" start_line="342" end_line="342" start_column="29" end_column="54" covered="no" />
            <range source_id="13" start_line="349" end_line="349" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="350" end_line="350" start_column="17" end_column="48" covered="no" />
            <range source_id="13" start_line="352" end_line="354" start_column="17" end_column="56" covered="no" />
            <range source_id="13" start_line="355" end_line="355" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="356" end_line="356" start_column="21" end_column="56" covered="no" />
            <range source_id="13" start_line="359" end_line="359" start_column="17" end_column="61" covered="no" />
            <range source_id="13" start_line="360" end_line="360" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="348" end_line="348" start_column="13" end_column="25" covered="no" />
            <range source_id="13" start_line="361" end_line="361" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="20712" token="0x60000b2" name="SearchDoctors()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="74" lines_covered="0" lines_partially_covered="0" lines_not_covered="42">
          <ranges>
            <range source_id="13" start_line="363" end_line="363" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="365" end_line="365" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="369" end_line="369" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="370" end_line="370" start_column="21" end_column="65" covered="no" />
            <range source_id="13" start_line="372" end_line="372" start_column="21" end_column="28" covered="no" />
            <range source_id="13" start_line="372" end_line="372" start_column="42" end_column="78" covered="no" />
            <range source_id="13" start_line="372" end_line="372" start_column="30" end_column="38" covered="no" />
            <range source_id="13" start_line="373" end_line="373" start_column="21" end_column="22" covered="no" />
            <range source_id="13" start_line="374" end_line="374" start_column="25" end_column="67" covered="no" />
            <range source_id="13" start_line="375" end_line="375" start_column="21" end_column="22" covered="no" />
            <range source_id="13" start_line="372" end_line="372" start_column="39" end_column="41" covered="no" />
            <range source_id="13" start_line="377" end_line="377" start_column="21" end_column="47" covered="no" />
            <range source_id="13" start_line="379" end_line="379" start_column="21" end_column="60" covered="no" />
            <range source_id="13" start_line="381" end_line="382" start_column="21" end_column="78" covered="no" />
            <range source_id="13" start_line="383" end_line="383" start_column="21" end_column="22" covered="no" />
            <range source_id="13" start_line="384" end_line="384" start_column="25" end_column="68" covered="no" />
            <range source_id="13" start_line="385" end_line="385" start_column="25" end_column="31" covered="no" />
            <range source_id="13" start_line="388" end_line="392" start_column="21" end_column="59" covered="no" />
            <range source_id="13" start_line="393" end_line="393" start_column="21" end_column="22" covered="no" />
            <range source_id="13" start_line="394" end_line="394" start_column="25" end_column="31" covered="no" />
            <range source_id="13" start_line="396" end_line="396" start_column="21" end_column="65" covered="no" />
            <range source_id="13" start_line="397" end_line="397" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="368" end_line="368" start_column="17" end_column="29" covered="no" />
            <range source_id="13" start_line="399" end_line="401" start_column="17" end_column="61" covered="no" />
            <range source_id="13" start_line="403" end_line="403" start_column="17" end_column="24" covered="no" />
            <range source_id="13" start_line="403" end_line="403" start_column="35" end_column="42" covered="no" />
            <range source_id="13" start_line="403" end_line="403" start_column="26" end_column="31" covered="no" />
            <range source_id="13" start_line="404" end_line="404" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="405" end_line="405" start_column="21" end_column="63" covered="no" />
            <range source_id="13" start_line="406" end_line="406" start_column="21" end_column="63" covered="no" />
            <range source_id="13" start_line="407" end_line="407" start_column="21" end_column="78" covered="no" />
            <range source_id="13" start_line="408" end_line="408" start_column="21" end_column="78" covered="no" />
            <range source_id="13" start_line="409" end_line="409" start_column="21" end_column="84" covered="no" />
            <range source_id="13" start_line="410" end_line="410" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="403" end_line="403" start_column="32" end_column="34" covered="no" />
            <range source_id="13" start_line="411" end_line="411" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="412" end_line="412" start_column="13" end_column="47" covered="no" />
            <range source_id="13" start_line="413" end_line="413" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="414" end_line="414" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="415" end_line="415" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="416" end_line="416" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="21328" token="0x60000b3" name="UpdatePatient()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="13" lines_covered="0" lines_partially_covered="0" lines_not_covered="16">
          <ranges>
            <range source_id="13" start_line="419" end_line="419" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="421" end_line="421" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="423" end_line="423" start_column="17" end_column="72" covered="no" />
            <range source_id="13" start_line="425" end_line="425" start_column="17" end_column="66" covered="no" />
            <range source_id="13" start_line="427" end_line="427" start_column="17" end_column="93" covered="no" />
            <range source_id="13" start_line="429" end_line="429" start_column="17" end_column="43" covered="no" />
            <range source_id="13" start_line="430" end_line="430" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="431" end_line="431" start_column="13" end_column="48" covered="no" />
            <range source_id="13" start_line="432" end_line="432" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="433" end_line="433" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="434" end_line="434" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="435" end_line="435" start_column="13" end_column="43" covered="no" />
            <range source_id="13" start_line="436" end_line="436" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="437" end_line="437" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="438" end_line="438" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="439" end_line="439" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="21448" token="0x60000b4" name="CollectPatientDetails()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="27" lines_covered="0" lines_partially_covered="0" lines_not_covered="20">
          <ranges>
            <range source_id="13" start_line="442" end_line="442" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="443" end_line="443" start_column="13" end_column="37" covered="no" />
            <range source_id="13" start_line="445" end_line="448" start_column="13" end_column="33" covered="no" />
            <range source_id="13" start_line="450" end_line="450" start_column="13" end_column="45" covered="no" />
            <range source_id="13" start_line="452" end_line="452" start_column="13" end_column="43" covered="no" />
            <range source_id="13" start_line="454" end_line="457" start_column="13" end_column="42" covered="no" />
            <range source_id="13" start_line="459" end_line="462" start_column="13" end_column="35" covered="no" />
            <range source_id="13" start_line="464" end_line="464" start_column="13" end_column="45" covered="no" />
            <range source_id="13" start_line="465" end_line="465" start_column="13" end_column="70" covered="no" />
            <range source_id="13" start_line="467" end_line="467" start_column="13" end_column="28" covered="no" />
            <range source_id="13" start_line="468" end_line="468" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="21688" token="0x60000b5" name="CheckDoctorAvailability()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="47" lines_covered="0" lines_partially_covered="0" lines_not_covered="47">
          <ranges>
            <range source_id="13" start_line="470" end_line="470" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="472" end_line="472" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="473" end_line="473" start_column="17" end_column="76" covered="no" />
            <range source_id="13" start_line="476" end_line="476" start_column="17" end_column="33" covered="no" />
            <range source_id="13" start_line="478" end_line="478" start_column="17" end_column="55" covered="no" />
            <range source_id="13" start_line="481" end_line="481" start_column="17" end_column="69" covered="no" />
            <range source_id="13" start_line="486" end_line="486" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="487" end_line="487" start_column="21" end_column="64" covered="no" />
            <range source_id="13" start_line="489" end_line="489" start_column="21" end_column="56" covered="no" />
            <range source_id="13" start_line="491" end_line="496" start_column="21" end_column="39" covered="no" />
            <range source_id="13" start_line="497" end_line="497" start_column="21" end_column="22" covered="no" />
            <range source_id="13" start_line="498" end_line="498" start_column="25" end_column="67" covered="no" />
            <range source_id="13" start_line="499" end_line="499" start_column="25" end_column="34" covered="no" />
            <range source_id="13" start_line="502" end_line="502" start_column="21" end_column="27" covered="no" />
            <range source_id="13" start_line="485" end_line="485" start_column="17" end_column="29" covered="no" />
            <range source_id="13" start_line="505" end_line="508" start_column="17" end_column="31" covered="no" />
            <range source_id="13" start_line="510" end_line="510" start_column="17" end_column="106" covered="no" />
            <range source_id="13" start_line="512" end_line="512" start_column="17" end_column="24" covered="no" />
            <range source_id="13" start_line="512" end_line="512" start_column="38" end_column="52" covered="no" />
            <range source_id="13" start_line="512" end_line="512" start_column="26" end_column="34" covered="no" />
            <range source_id="13" start_line="513" end_line="513" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="514" end_line="514" start_column="21" end_column="45" covered="no" />
            <range source_id="13" start_line="515" end_line="515" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="512" end_line="512" start_column="35" end_column="37" covered="no" />
            <range source_id="13" start_line="516" end_line="516" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="517" end_line="517" start_column="13" end_column="47" covered="no" />
            <range source_id="13" start_line="518" end_line="518" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="519" end_line="519" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="520" end_line="520" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="521" end_line="521" start_column="13" end_column="41" covered="no" />
            <range source_id="13" start_line="522" end_line="522" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="523" end_line="523" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="524" end_line="524" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="525" end_line="525" start_column="13" end_column="49" covered="no" />
            <range source_id="13" start_line="526" end_line="526" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="527" end_line="527" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="528" end_line="528" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="529" end_line="529" start_column="13" end_column="48" covered="no" />
            <range source_id="13" start_line="530" end_line="530" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="531" end_line="531" start_column="17" end_column="47" covered="no" />
            <range source_id="13" start_line="532" end_line="532" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="533" end_line="533" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="22180" token="0x60000b6" name="ReadDOB()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="17" lines_covered="0" lines_partially_covered="0" lines_not_covered="20">
          <ranges>
            <range source_id="13" start_line="535" end_line="535" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="537" end_line="537" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="538" end_line="538" start_column="17" end_column="53" covered="no" />
            <range source_id="13" start_line="540" end_line="540" start_column="17" end_column="52" covered="no" />
            <range source_id="13" start_line="542" end_line="547" start_column="17" end_column="43" covered="no" />
            <range source_id="13" start_line="548" end_line="548" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="549" end_line="549" start_column="21" end_column="63" covered="no" />
            <range source_id="13" start_line="550" end_line="550" start_column="21" end_column="30" covered="no" />
            <range source_id="13" start_line="553" end_line="553" start_column="17" end_column="65" covered="no" />
            <range source_id="13" start_line="554" end_line="554" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="555" end_line="555" start_column="21" end_column="64" covered="no" />
            <range source_id="13" start_line="556" end_line="556" start_column="21" end_column="30" covered="no" />
            <range source_id="13" start_line="559" end_line="559" start_column="17" end_column="28" covered="no" />
            <range source_id="13" start_line="536" end_line="536" start_column="13" end_column="25" covered="no" />
            <range source_id="13" start_line="561" end_line="561" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="22300" token="0x60000b7" name="ReadGender()" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="14" lines_covered="0" lines_partially_covered="0" lines_not_covered="12">
          <ranges>
            <range source_id="13" start_line="564" end_line="564" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="566" end_line="566" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="567" end_line="567" start_column="17" end_column="63" covered="no" />
            <range source_id="13" start_line="569" end_line="569" start_column="17" end_column="52" covered="no" />
            <range source_id="13" start_line="571" end_line="572" start_column="17" end_column="44" covered="no" />
            <range source_id="13" start_line="573" end_line="573" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="574" end_line="574" start_column="21" end_column="35" covered="no" />
            <range source_id="13" start_line="577" end_line="577" start_column="17" end_column="54" covered="no" />
            <range source_id="13" start_line="578" end_line="578" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="565" end_line="565" start_column="13" end_column="25" covered="no" />
            <range source_id="13" start_line="579" end_line="579" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="22384" token="0x60000b8" name="ReadValidInput(string, System.Func&lt;string, bool&gt;, string)" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="14" lines_covered="0" lines_partially_covered="0" lines_not_covered="14">
          <ranges>
            <range source_id="13" start_line="586" end_line="586" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="588" end_line="588" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="589" end_line="589" start_column="17" end_column="40" covered="no" />
            <range source_id="13" start_line="591" end_line="591" start_column="17" end_column="52" covered="no" />
            <range source_id="13" start_line="593" end_line="593" start_column="17" end_column="54" covered="no" />
            <range source_id="13" start_line="594" end_line="594" start_column="17" end_column="18" covered="no" />
            <range source_id="13" start_line="595" end_line="595" start_column="21" end_column="65" covered="no" />
            <range source_id="13" start_line="596" end_line="596" start_column="21" end_column="30" covered="no" />
            <range source_id="13" start_line="599" end_line="599" start_column="17" end_column="38" covered="no" />
            <range source_id="13" start_line="600" end_line="600" start_column="21" end_column="34" covered="no" />
            <range source_id="13" start_line="602" end_line="602" start_column="17" end_column="49" covered="no" />
            <range source_id="13" start_line="603" end_line="603" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="587" end_line="587" start_column="13" end_column="25" covered="no" />
            <range source_id="13" start_line="604" end_line="604" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="22468" token="0x60000b9" name="ReadInt(string)" namespace="HealthApp.Menus" type_name="PatientMenu" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="10" lines_covered="0" lines_partially_covered="0" lines_not_covered="9">
          <ranges>
            <range source_id="13" start_line="606" end_line="606" start_column="9" end_column="10" covered="no" />
            <range source_id="13" start_line="608" end_line="608" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="609" end_line="609" start_column="17" end_column="40" covered="no" />
            <range source_id="13" start_line="610" end_line="610" start_column="17" end_column="69" covered="no" />
            <range source_id="13" start_line="611" end_line="611" start_column="21" end_column="34" covered="no" />
            <range source_id="13" start_line="613" end_line="613" start_column="17" end_column="61" covered="no" />
            <range source_id="13" start_line="615" end_line="615" start_column="13" end_column="14" covered="no" />
            <range source_id="13" start_line="607" end_line="607" start_column="13" end_column="25" covered="no" />
            <range source_id="13" start_line="616" end_line="616" start_column="9" end_column="10" covered="no" />
          </ranges>
        </function>
        <function id="22529" token="0x60000ba" name="AppointmentConflictException(string)" namespace="HealthApp.Exceptions" type_name="AppointmentConflictException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="14" start_line="10" end_line="10" start_column="15" end_column="28" covered="yes" />
            <range source_id="14" start_line="11" end_line="11" start_column="9" end_column="10" covered="yes" />
            <range source_id="14" start_line="12" end_line="12" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="22540" token="0x60000bb" name="AppointmentAlreadyCancelledException(string)" namespace="HealthApp.Exceptions" type_name="AppointmentAlreadyCancelledException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="15" start_line="9" end_line="9" start_column="69" end_column="82" covered="yes" />
            <range source_id="15" start_line="9" end_line="9" start_column="83" end_column="84" covered="yes" />
            <range source_id="15" start_line="9" end_line="9" start_column="85" end_column="86" covered="yes" />
          </ranges>
        </function>
        <function id="22551" token="0x60000bc" name="AppointmentAlreadyCompletedException(string)" namespace="HealthApp.Exceptions" type_name="AppointmentAlreadyCompletedException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="16" start_line="9" end_line="9" start_column="70" end_column="83" covered="yes" />
            <range source_id="16" start_line="9" end_line="9" start_column="84" end_column="85" covered="yes" />
            <range source_id="16" start_line="9" end_line="9" start_column="86" end_column="87" covered="yes" />
          </ranges>
        </function>
        <function id="22562" token="0x60000bd" name="AppointmentAlreadyConfirmedException(string)" namespace="HealthApp.Exceptions" type_name="AppointmentAlreadyConfirmedException" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="17" start_line="9" end_line="9" start_column="71" end_column="84" covered="no" />
            <range source_id="17" start_line="9" end_line="9" start_column="85" end_column="86" covered="no" />
            <range source_id="17" start_line="9" end_line="9" start_column="87" end_column="88" covered="no" />
          </ranges>
        </function>
        <function id="22573" token="0x60000be" name="AppointmentNotFoundException(string)" namespace="HealthApp.Exceptions" type_name="AppointmentNotFoundException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="18" start_line="9" end_line="9" start_column="61" end_column="74" covered="yes" />
            <range source_id="18" start_line="9" end_line="9" start_column="75" end_column="76" covered="yes" />
            <range source_id="18" start_line="9" end_line="9" start_column="77" end_column="78" covered="yes" />
          </ranges>
        </function>
        <function id="22584" token="0x60000bf" name="DoctorNotFoundException(string)" namespace="HealthApp.Exceptions" type_name="DoctorNotFoundException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="19" start_line="15" end_line="15" start_column="62" end_column="75" covered="yes" />
            <range source_id="19" start_line="15" end_line="15" start_column="76" end_column="77" covered="yes" />
            <range source_id="19" start_line="15" end_line="15" start_column="78" end_column="79" covered="yes" />
          </ranges>
        </function>
        <function id="22595" token="0x60000c0" name="DoctorUnavailableException(string)" namespace="HealthApp.Exceptions" type_name="DoctorUnavailableException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="20" start_line="10" end_line="10" start_column="15" end_column="28" covered="yes" />
            <range source_id="20" start_line="11" end_line="11" start_column="9" end_column="10" covered="yes" />
            <range source_id="20" start_line="12" end_line="12" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="22606" token="0x60000c1" name="InvalidDateRangeException(string)" namespace="HealthApp.Exceptions" type_name="InvalidDateRangeException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="21" start_line="9" end_line="9" start_column="60" end_column="73" covered="yes" />
            <range source_id="21" start_line="9" end_line="9" start_column="74" end_column="75" covered="yes" />
            <range source_id="21" start_line="9" end_line="9" start_column="76" end_column="77" covered="yes" />
          </ranges>
        </function>
        <function id="22617" token="0x60000c2" name="InvalidSlotException(string)" namespace="HealthApp.Exceptions" type_name="InvalidSlotException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="22" start_line="9" end_line="9" start_column="55" end_column="68" covered="yes" />
            <range source_id="22" start_line="9" end_line="9" start_column="69" end_column="70" covered="yes" />
            <range source_id="22" start_line="9" end_line="9" start_column="71" end_column="72" covered="yes" />
          </ranges>
        </function>
        <function id="22628" token="0x60000c3" name="NoAppointmentsFoundException(string)" namespace="HealthApp.Exceptions" type_name="NoAppointmentsFoundException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="23" start_line="9" end_line="9" start_column="63" end_column="76" covered="yes" />
            <range source_id="23" start_line="9" end_line="9" start_column="77" end_column="78" covered="yes" />
            <range source_id="23" start_line="9" end_line="9" start_column="79" end_column="80" covered="yes" />
          </ranges>
        </function>
        <function id="22639" token="0x60000c4" name="NoDoctorsRegisteredException(string)" namespace="HealthApp.Exceptions" type_name="NoDoctorsRegisteredException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="24" start_line="9" end_line="9" start_column="61" end_column="74" covered="yes" />
            <range source_id="24" start_line="9" end_line="9" start_column="75" end_column="76" covered="yes" />
            <range source_id="24" start_line="9" end_line="9" start_column="77" end_column="78" covered="yes" />
          </ranges>
        </function>
        <function id="22650" token="0x60000c5" name="NoHealthRecordAvailableException(string)" namespace="HealthApp.Exceptions" type_name="NoHealthRecordAvailableException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="25" start_line="9" end_line="9" start_column="65" end_column="78" covered="yes" />
            <range source_id="25" start_line="9" end_line="9" start_column="79" end_column="80" covered="yes" />
            <range source_id="25" start_line="9" end_line="9" start_column="81" end_column="82" covered="yes" />
          </ranges>
        </function>
        <function id="22661" token="0x60000c6" name="NoPatientRegisteredException(string)" namespace="HealthApp.Exceptions" type_name="NoPatientRegisteredException" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="26" start_line="9" end_line="9" start_column="63" end_column="76" covered="no" />
            <range source_id="26" start_line="9" end_line="9" start_column="77" end_column="78" covered="no" />
            <range source_id="26" start_line="9" end_line="9" start_column="79" end_column="80" covered="no" />
          </ranges>
        </function>
        <function id="22672" token="0x60000c7" name="NotValidSpecialisationException(string)" namespace="HealthApp.Exceptions" type_name="NotValidSpecialisationException" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="27" start_line="9" end_line="9" start_column="64" end_column="77" covered="no" />
            <range source_id="27" start_line="9" end_line="9" start_column="78" end_column="79" covered="no" />
            <range source_id="27" start_line="9" end_line="9" start_column="80" end_column="81" covered="no" />
          </ranges>
        </function>
        <function id="22683" token="0x60000c8" name="PastDateException(string)" namespace="HealthApp.Exceptions" type_name="PastDateException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="28" start_line="10" end_line="10" start_column="15" end_column="28" covered="yes" />
            <range source_id="28" start_line="11" end_line="11" start_column="9" end_column="10" covered="yes" />
            <range source_id="28" start_line="12" end_line="12" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="22694" token="0x60000c9" name="PatientNotFoundException(string)" namespace="HealthApp.Exceptions" type_name="PatientNotFoundException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="29" start_line="9" end_line="9" start_column="59" end_column="72" covered="yes" />
            <range source_id="29" start_line="9" end_line="9" start_column="73" end_column="74" covered="yes" />
            <range source_id="29" start_line="9" end_line="9" start_column="75" end_column="76" covered="yes" />
          </ranges>
        </function>
        <function id="22705" token="0x60000ca" name="SlotAlreadyOverException(string)" namespace="HealthApp.Exceptions" type_name="SlotAlreadyOverException" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="30" start_line="9" end_line="9" start_column="59" end_column="72" covered="yes" />
            <range source_id="30" start_line="10" end_line="10" start_column="9" end_column="10" covered="yes" />
            <range source_id="30" start_line="12" end_line="12" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="22733" token="0x60000cd" name="AppointmentDb()" namespace="HealthApp.Database" type_name="AppointmentDb" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="31" start_line="10" end_line="10" start_column="63" end_column="65" covered="yes" />
          </ranges>
        </function>
        <function id="22772" token="0x60000d0" name="DoctorDb()" namespace="HealthApp.Database" type_name="DoctorDb" block_coverage="100.00" line_coverage="100.00" blocks_covered="58" blocks_not_covered="0" lines_covered="62" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="32" start_line="10" end_line="71" start_column="53" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="23308" token="0x60000d3" name="HealthRecordDb()" namespace="HealthApp.Database" type_name="HealthRecordDb" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="33" start_line="10" end_line="10" start_column="59" end_column="61" covered="yes" />
          </ranges>
        </function>
        <function id="23345" token="0x60000d6" name="PatientDb()" namespace="HealthApp.Database" type_name="PatientDb" block_coverage="100.00" line_coverage="100.00" blocks_covered="4" blocks_not_covered="0" lines_covered="4" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="34" start_line="11" end_line="11" start_column="9" end_column="27" covered="yes" />
            <range source_id="34" start_line="12" end_line="12" start_column="9" end_column="10" covered="yes" />
            <range source_id="34" start_line="13" end_line="13" start_column="13" end_column="43" covered="yes" />
            <range source_id="34" start_line="14" end_line="14" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="23368" token="0x60000d7" name="GetDummyPatients()" namespace="HealthApp.Database" type_name="PatientDb" block_coverage="100.00" line_coverage="100.00" blocks_covered="18" blocks_not_covered="0" lines_covered="54" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="34" start_line="17" end_line="17" start_column="9" end_column="10" covered="yes" />
            <range source_id="34" start_line="18" end_line="69" start_column="13" end_column="15" covered="yes" />
            <range source_id="34" start_line="70" end_line="70" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="23628" token="0x60000d8" name="CreatePatient(int, string, System.DateOnly, HealthApp.Model.GenderType, string, string, string)" namespace="HealthApp.Database" type_name="PatientDb" block_coverage="100.00" line_coverage="100.00" blocks_covered="10" blocks_not_covered="0" lines_covered="12" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="34" start_line="80" end_line="80" start_column="9" end_column="10" covered="yes" />
            <range source_id="34" start_line="81" end_line="90" start_column="13" end_column="15" covered="yes" />
            <range source_id="34" start_line="91" end_line="91" start_column="9" end_column="10" covered="yes" />
          </ranges>
        </function>
        <function id="23712" token="0x60000d9" name="TimeSlots()" namespace="HealthApp.Constant" type_name="TimeSlots" block_coverage="100.00" line_coverage="100.00" blocks_covered="12" blocks_not_covered="0" lines_covered="11" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="35" start_line="9" end_line="19" start_column="9" end_column="11" covered="yes" />
          </ranges>
        </function>
        <function id="23947" token="0x60000dd" name="&lt;GetAppointmentsByPatient&gt;b__6_1(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="0" start_line="211" end_line="211" start_column="31" end_column="46" covered="no" />
          </ranges>
        </function>
        <function id="23955" token="0x60000de" name="&lt;GetAppointmentsByPatient&gt;b__6_2(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="0" start_line="212" end_line="212" start_column="30" end_column="40" covered="no" />
          </ranges>
        </function>
        <function id="23963" token="0x60000df" name="&lt;GetUpcomingAppointmentsByDoctor&gt;b__7_1(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="0" start_line="243" end_line="243" start_column="31" end_column="46" covered="no" />
          </ranges>
        </function>
        <function id="23971" token="0x60000e0" name="&lt;GetUpcomingAppointmentsByDoctor&gt;b__7_2(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="0" start_line="244" end_line="244" start_column="30" end_column="40" covered="no" />
          </ranges>
        </function>
        <function id="23979" token="0x60000e1" name="&lt;CheckDoctorAvailability&gt;b__8_1(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="283" end_line="283" start_column="30" end_column="40" covered="yes" />
          </ranges>
        </function>
        <function id="23987" token="0x60000e2" name="&lt;GetPendingAppointmentsByDoctor&gt;b__9_1(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="0" start_line="310" end_line="310" start_column="31" end_column="46" covered="no" />
          </ranges>
        </function>
        <function id="23995" token="0x60000e3" name="&lt;GetPendingAppointmentsByDoctor&gt;b__9_2(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="0" start_line="311" end_line="311" start_column="30" end_column="40" covered="no" />
          </ranges>
        </function>
        <function id="24012" token="0x60000e5" name="&lt;BookAppointment&gt;b__0(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c__DisplayClass2_0" block_coverage="100.00" line_coverage="100.00" blocks_covered="17" blocks_not_covered="0" lines_covered="7" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="73" end_line="79" start_column="17" end_column="56" covered="yes" />
          </ranges>
        </function>
        <function id="24120" token="0x60000e6" name="&lt;BookAppointment&gt;b__1(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c__DisplayClass2_0" block_coverage="37.50" line_coverage="0.00" blocks_covered="6" blocks_not_covered="10" lines_covered="0" lines_partially_covered="7" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="91" end_line="97" start_column="17" end_column="56" covered="partial" />
          </ranges>
        </function>
        <function id="24224" token="0x60000e7" name="&lt;BookAppointment&gt;b__2(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c__DisplayClass2_0" block_coverage="93.75" line_coverage="0.00" blocks_covered="15" blocks_not_covered="1" lines_covered="0" lines_partially_covered="10" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="107" end_line="116" start_column="21" end_column="48" covered="partial" />
          </ranges>
        </function>
        <function id="24336" token="0x60000e9" name="&lt;GetAppointmentsByPatient&gt;b__0(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c__DisplayClass6_0" block_coverage="81.25" line_coverage="0.00" blocks_covered="13" blocks_not_covered="3" lines_covered="0" lines_partially_covered="5" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="205" end_line="209" start_column="21" end_column="59" covered="partial" />
          </ranges>
        </function>
        <function id="24432" token="0x60000eb" name="&lt;GetUpcomingAppointmentsByDoctor&gt;b__0(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c__DisplayClass7_0" block_coverage="95.45" line_coverage="0.00" blocks_covered="21" blocks_not_covered="1" lines_covered="0" lines_partially_covered="5" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="238" end_line="242" start_column="21" end_column="62" covered="partial" />
          </ranges>
        </function>
        <function id="24576" token="0x60000ed" name="&lt;CheckDoctorAvailability&gt;b__0(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c__DisplayClass8_0" block_coverage="91.67" line_coverage="0.00" blocks_covered="11" blocks_not_covered="1" lines_covered="0" lines_partially_covered="5" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="278" end_line="282" start_column="21" end_column="60" covered="partial" />
          </ranges>
        </function>
        <function id="24664" token="0x60000ef" name="&lt;GetPendingAppointmentsByDoctor&gt;b__0(HealthApp.Model.Appointment)" namespace="HealthApp.Service.Impl" type_name="AppointmentService.&lt;&gt;c__DisplayClass9_0" block_coverage="85.71" line_coverage="0.00" blocks_covered="6" blocks_not_covered="1" lines_covered="0" lines_partially_covered="3" lines_not_covered="0">
          <ranges>
            <range source_id="0" start_line="307" end_line="309" start_column="21" end_column="58" covered="partial" />
          </ranges>
        </function>
        <function id="24718" token="0x60000f2" name="&lt;AddDoctor&gt;b__2_0(HealthApp.Model.Doctor)" namespace="HealthApp.Service.Impl" type_name="DoctorService.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="1" start_line="27" end_line="27" start_column="38" end_column="48" covered="no" />
          </ranges>
        </function>
        <function id="24735" token="0x60000f4" name="&lt;SearchBySpecialisation&gt;b__0(HealthApp.Model.Doctor)" namespace="HealthApp.Service.Impl" type_name="DoctorService.&lt;&gt;c__DisplayClass5_0" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="1" start_line="65" end_line="65" start_column="29" end_column="63" covered="yes" />
          </ranges>
        </function>
        <function id="24772" token="0x60000f7" name="&lt;GetHealthRecordsByDoctor&gt;b__4_1(HealthApp.Model.HealthRecord)" namespace="HealthApp.Service.Impl" type_name="HealthRecordService.&lt;&gt;c" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="56" end_line="56" start_column="41" end_column="52" covered="yes" />
          </ranges>
        </function>
        <function id="24789" token="0x60000f9" name="&lt;GetPatientRecords&gt;b__0(HealthApp.Model.HealthRecord)" namespace="HealthApp.Service.Impl" type_name="HealthRecordService.&lt;&gt;c__DisplayClass3_0" block_coverage="100.00" line_coverage="100.00" blocks_covered="3" blocks_not_covered="0" lines_covered="2" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="36" end_line="37" start_column="21" end_column="30" covered="yes" />
          </ranges>
        </function>
        <function id="24819" token="0x60000fb" name="&lt;GetHealthRecordsByDoctor&gt;b__0(HealthApp.Model.HealthRecord)" namespace="HealthApp.Service.Impl" type_name="HealthRecordService.&lt;&gt;c__DisplayClass4_0" block_coverage="100.00" line_coverage="100.00" blocks_covered="8" blocks_not_covered="0" lines_covered="3" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="2" start_line="53" end_line="55" start_column="21" end_column="53" covered="yes" />
          </ranges>
        </function>
        <function id="24883" token="0x60000fe" name="&lt;RegisterPatient&gt;b__2_0(HealthApp.Model.Patient)" namespace="HealthApp.Service.Impl" type_name="PatientService.&lt;&gt;c" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="3" start_line="27" end_line="27" start_column="39" end_column="50" covered="yes" />
          </ranges>
        </function>
        <function id="24900" token="0x6000100" name="&lt;GetById&gt;b__0(HealthApp.Model.Appointment)" namespace="HealthApp.Repository.Impl" type_name="AppointmentRepository.&lt;&gt;c__DisplayClass4_0" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="4" start_line="28" end_line="28" start_column="68" end_column="89" covered="yes" />
          </ranges>
        </function>
        <function id="24925" token="0x6000102" name="&lt;GetById&gt;b__0(HealthApp.Model.Doctor)" namespace="HealthApp.Repository.Impl" type_name="DoctorRepository.&lt;&gt;c__DisplayClass4_0" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="32" end_line="32" start_column="38" end_column="54" covered="yes" />
          </ranges>
        </function>
        <function id="24950" token="0x6000104" name="&lt;ChangeDoctorStatus&gt;b__0(HealthApp.Model.Doctor)" namespace="HealthApp.Repository.Impl" type_name="DoctorRepository.&lt;&gt;c__DisplayClass5_0" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="5" start_line="40" end_line="40" start_column="56" end_column="72" covered="yes" />
          </ranges>
        </function>
        <function id="24975" token="0x6000106" name="&lt;GetById&gt;b__0(HealthApp.Model.Patient)" namespace="HealthApp.Repository.Impl" type_name="PatientRepository.&lt;&gt;c__DisplayClass4_0" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="32" end_line="32" start_column="52" end_column="70" covered="yes" />
          </ranges>
        </function>
        <function id="25000" token="0x6000108" name="&lt;UpdatePatient&gt;b__0(HealthApp.Model.Patient)" namespace="HealthApp.Repository.Impl" type_name="PatientRepository.&lt;&gt;c__DisplayClass5_0" block_coverage="100.00" line_coverage="100.00" blocks_covered="2" blocks_not_covered="0" lines_covered="1" lines_partially_covered="0" lines_not_covered="0">
          <ranges>
            <range source_id="7" start_line="38" end_line="38" start_column="55" end_column="73" covered="yes" />
          </ranges>
        </function>
        <function id="25040" token="0x600010b" name="&lt;AddDoctor&gt;b__7_0(string)" namespace="HealthApp.Menus" type_name="DoctorMenu.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="5" lines_covered="0" lines_partially_covered="0" lines_not_covered="4">
          <ranges>
            <range source_id="12" start_line="154" end_line="154" start_column="25" end_column="26" covered="no" />
            <range source_id="12" start_line="155" end_line="155" start_column="29" end_column="72" covered="no" />
            <range source_id="12" start_line="156" end_line="156" start_column="29" end_column="55" covered="no" />
            <range source_id="12" start_line="157" end_line="157" start_column="25" end_column="26" covered="no" />
          </ranges>
        </function>
        <function id="25080" token="0x600010c" name="&lt;AddDoctor&gt;b__7_1(string)" namespace="HealthApp.Menus" type_name="DoctorMenu.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="5" lines_covered="0" lines_partially_covered="0" lines_not_covered="4">
          <ranges>
            <range source_id="12" start_line="169" end_line="169" start_column="25" end_column="26" covered="no" />
            <range source_id="12" start_line="170" end_line="170" start_column="29" end_column="75" covered="no" />
            <range source_id="12" start_line="171" end_line="171" start_column="29" end_column="56" covered="no" />
            <range source_id="12" start_line="172" end_line="172" start_column="25" end_column="26" covered="no" />
          </ranges>
        </function>
        <function id="25120" token="0x600010d" name="&lt;AddDoctor&gt;b__7_2(string)" namespace="HealthApp.Menus" type_name="DoctorMenu.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="5" lines_covered="0" lines_partially_covered="0" lines_not_covered="4">
          <ranges>
            <range source_id="12" start_line="178" end_line="178" start_column="25" end_column="26" covered="no" />
            <range source_id="12" start_line="179" end_line="179" start_column="29" end_column="77" covered="no" />
            <range source_id="12" start_line="180" end_line="180" start_column="29" end_column="62" covered="no" />
            <range source_id="12" start_line="181" end_line="181" start_column="25" end_column="26" covered="no" />
          </ranges>
        </function>
        <function id="25160" token="0x600010e" name="&lt;AddHealthRecord&gt;b__12_0(string)" namespace="HealthApp.Menus" type_name="DoctorMenu.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="12" start_line="276" end_line="276" start_column="28" end_column="50" covered="no" />
          </ranges>
        </function>
        <function id="25181" token="0x600010f" name="&lt;AddHealthRecord&gt;b__12_1(string)" namespace="HealthApp.Menus" type_name="DoctorMenu.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="12" start_line="318" end_line="318" start_column="26" end_column="55" covered="no" />
          </ranges>
        </function>
        <function id="25192" token="0x6000110" name="&lt;AddHealthRecord&gt;b__12_2(string)" namespace="HealthApp.Menus" type_name="DoctorMenu.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="12" start_line="324" end_line="324" start_column="26" end_column="55" covered="no" />
          </ranges>
        </function>
        <function id="25203" token="0x6000111" name="&lt;AddHealthRecord&gt;b__12_3(string)" namespace="HealthApp.Menus" type_name="DoctorMenu.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="2" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="12" start_line="330" end_line="330" start_column="26" end_column="55" covered="no" />
          </ranges>
        </function>
        <function id="25235" token="0x6000114" name="&lt;CollectPatientDetails&gt;b__15_0(string)" namespace="HealthApp.Menus" type_name="PatientMenu.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="4" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="13" start_line="447" end_line="447" start_column="26" end_column="72" covered="no" />
          </ranges>
        </function>
        <function id="25255" token="0x6000115" name="&lt;CollectPatientDetails&gt;b__15_1(string)" namespace="HealthApp.Menus" type_name="PatientMenu.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="4" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="13" start_line="456" end_line="456" start_column="26" end_column="82" covered="no" />
          </ranges>
        </function>
        <function id="25275" token="0x6000116" name="&lt;CollectPatientDetails&gt;b__15_2(string)" namespace="HealthApp.Menus" type_name="PatientMenu.&lt;&gt;c" block_coverage="0.00" line_coverage="0.00" blocks_covered="0" blocks_not_covered="4" lines_covered="0" lines_partially_covered="0" lines_not_covered="1">
          <ranges>
            <range source_id="13" start_line="461" end_line="461" start_column="26" end_column="70" covered="no" />
          </ranges>
        </function>
      </functions>
      <source_files>
        <source_file id="0" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Service\Impl\AppointmentService.cs" checksum_type="SHA256" checksum="D55E27DDD93094EB32AEFFC45675EAE6CF568034FD8A27C7E263D8E92A0B8F5D" />
        <source_file id="1" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Service\Impl\DoctorService.cs" checksum_type="SHA256" checksum="79CF95765C4216A8CF73C14B8C7A171AF5C2A6705A00650128F1E3325DFF084D" />
        <source_file id="2" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Service\Impl\HealthRecordService.cs" checksum_type="SHA256" checksum="383E9B0B769170032FF93BFCEBDC1138B1BEC884A52827F6E6F2FFAF4DF11336" />
        <source_file id="3" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Service\Impl\PatientService.cs" checksum_type="SHA256" checksum="54B8BA49A12C66BE43125A71DCD8E0535B8195D327A894D806505FB8C1842E19" />
        <source_file id="4" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Repository\Impl\AppointmentRepository.cs" checksum_type="SHA256" checksum="019A501D8FA8B5FB2558582E20B7F59467DFED1F8688DD7D7CE8255B9E329773" />
        <source_file id="5" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Repository\Impl\DoctorRepository.cs" checksum_type="SHA256" checksum="88DCEB112C5FAC5FACFC62F92F16704365F865A4F64E1857AED5BC6BCD2D08A5" />
        <source_file id="6" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Repository\Impl\HealthRecordRepository.cs" checksum_type="SHA256" checksum="2CBE47E91677886B872DB2D6994B72B6E75516EC40158381CBF5A0819C851E60" />
        <source_file id="7" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Repository\Impl\PatientRepository.cs" checksum_type="SHA256" checksum="CA63CCE749A551BCA08E96AEFF7640AAB4EADCD2D70E9C6B428648FF9C9E50A5" />
        <source_file id="8" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Model\Appointment.cs" checksum_type="SHA256" checksum="F2B8B5D36255B7414315566774B0126F9C135BA2D95218A12316AC328ACD1599" />
        <source_file id="9" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Model\Doctor.cs" checksum_type="SHA256" checksum="F92CB3BB9E6994D496736636057D1432F69EC976A92352CD10D5CB127AE2DA98" />
        <source_file id="10" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Model\HealthRecord.cs" checksum_type="SHA256" checksum="5F44CDE856C6F32252B150F60B1178B7E8B88E875739EB00DAF9DC7EAB4F35BC" />
        <source_file id="11" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Model\Patient.cs" checksum_type="SHA256" checksum="57373CC182E6CEFF5C3D34DF6FB19B19E136CAE2BFF8BC0C3F88E5A6CB6F4DF4" />
        <source_file id="12" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Menus\DoctorMenu.cs" checksum_type="SHA256" checksum="8F818879816B3E6CB934141B6D51CDB971A54E48281C3371F935CB85AC2F3B4B" />
        <source_file id="13" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Menus\PatientMenu.cs" checksum_type="SHA256" checksum="98B51DC478BD82E8ADF5CC130E69C818BF87BB580C0293407551D514263F9D64" />
        <source_file id="14" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\ApplicationConflictException.cs" checksum_type="SHA256" checksum="B30905CF135A9E59C91D6BC5B82AF216BD1E5FCEE3A87A721A7B96F81EFC51B6" />
        <source_file id="15" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\AppointmentAlreadyCancelledException.cs" checksum_type="SHA256" checksum="F159B731EA12AAB401F08FA45CBAB36CD2B016FC250CBAD785A728B12D31B5E8" />
        <source_file id="16" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\AppointmentAlreadyCompletedException.cs" checksum_type="SHA256" checksum="307D6416C92A23E3D367675394922447458B4D50C0AD3E121400AB10C44D6BE4" />
        <source_file id="17" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\AppointmentAlreadyConfirmedException.cs" checksum_type="SHA256" checksum="5B1BAC608674C503D5DC605F3A32469317CF6B0F91BD105D19218934A27A401F" />
        <source_file id="18" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\AppointmentNotFoundException.cs" checksum_type="SHA256" checksum="C3B1AEB28BCE3820DAC9D9BC890C3ACAA1AD9ED71FBB6B3A8FAE86240FA0C24D" />
        <source_file id="19" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\DoctorNotFoundException.cs" checksum_type="SHA256" checksum="9F2D901F766021DBDB81EE4844887AB6110ACD93A4888881A3F600218ECF30EF" />
        <source_file id="20" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\DoctorUnavailableException.cs" checksum_type="SHA256" checksum="B29890F25C22CD7AE455A468D806E8F40BD7C91C39FF9A55FAAB372F932F41C2" />
        <source_file id="21" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\InvalidDateRangeException.cs" checksum_type="SHA256" checksum="04FD40414C070D6EB1BDE04D684658F031CE8E73F1A7FF226FB3837B8C0570B6" />
        <source_file id="22" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\InvalidSlotException.cs" checksum_type="SHA256" checksum="AFF6E03D0A7626B88D2F1D6080B815737F3E5B3155ECBB2B945A7886EA627014" />
        <source_file id="23" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\NoAppointmentsFoundException.cs" checksum_type="SHA256" checksum="41451C2A35F308F9C0FD072D0D4A51095F5B1E77479979961869B31301561C86" />
        <source_file id="24" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\NoDoctorsRegisteredException.cs" checksum_type="SHA256" checksum="AFF5D85DCDDC7DF7D592E97B869101227DDE54E78FEC8601D1C20AFC4312B083" />
        <source_file id="25" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\NoHealthRecordAvailableException.cs" checksum_type="SHA256" checksum="210627B70A24406C71145E4D763F4CE15E34BC3E181CB636F1FC5EB9534323CE" />
        <source_file id="26" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\NoPatientRegisteredException.cs" checksum_type="SHA256" checksum="8F6D61ED3BF346EE28D98B7A456E1577B96BA60456644C87D6749C1A0CD83C85" />
        <source_file id="27" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\NotValidSpecialisationException.cs" checksum_type="SHA256" checksum="B7646086CA66D0C9AE732692B861638973DBF0E106F33C0EA9A22C5353AA4EF7" />
        <source_file id="28" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\PastDateException.cs" checksum_type="SHA256" checksum="B25BDD1D8DC7EF5A4B4F380762BF1789CCB047DE483B9310ECEE434542325C65" />
        <source_file id="29" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\PatientNotFoundException.cs" checksum_type="SHA256" checksum="28C2BBAB8300A00B3F31ECAC786C235457ACFB785B405A1831994FDDC903E070" />
        <source_file id="30" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Exceptions\SlotAlreadyOverException.cs" checksum_type="SHA256" checksum="9DA40AB05B79B1018D774AE0E661D387AF4812C037CC2527D9B00F592BC0364C" />
        <source_file id="31" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Database\AppointmentDb.cs" checksum_type="SHA256" checksum="98C714357E59D59B96DAD58512190E169A006AC7C43F2FD00D52785CCD70B628" />
        <source_file id="32" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Database\DoctorDb.cs" checksum_type="SHA256" checksum="D1AC72188C747AB94380D55DE2666A8020768BF26869D56499DDD61F8B0158C6" />
        <source_file id="33" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Database\HealthRecordDb.cs" checksum_type="SHA256" checksum="F1CDD8D5A3408791CFF6DDA5247351E7886944BFF6ED858EB88EC52ADDE0BA79" />
        <source_file id="34" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Database\PatientDb.cs" checksum_type="SHA256" checksum="A512F206F053C698043986B682C63AE0AE28B1282EB69FFA5E7EE361B38CB4A3" />
        <source_file id="35" path="C:\Users\310189\source\repos\Main_HAP_Pod1\HealthApp\HealthApp\Constant\TimeSlot.cs" checksum_type="SHA256" checksum="72D9A5E3657C874C91C141D73BCEBD172E19C99525870F7D3AA8E1224657E42D" />
      </source_files>
      <skipped_functions>
        <skipped_function id="8272" original_id="8272" token="0x6000001" name="&lt;Main&gt;$(string[])" type_name="Program" reason="attribute_excluded" />
        <skipped_function id="12724" original_id="12724" token="0x600004c" name="get_AppointmentId()" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12732" original_id="12732" token="0x600004d" name="set_AppointmentId(int)" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12741" original_id="12741" token="0x600004e" name="get_Patient()" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12749" original_id="12749" token="0x600004f" name="set_Patient(HealthApp.Model.Patient)" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12758" original_id="12758" token="0x6000050" name="get_Doctor()" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12766" original_id="12766" token="0x6000051" name="set_Doctor(HealthApp.Model.Doctor)" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12775" original_id="12775" token="0x6000052" name="get_ScheduledDate()" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12783" original_id="12783" token="0x6000053" name="set_ScheduledDate(System.DateTime)" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12792" original_id="12792" token="0x6000054" name="get_TimeSlot()" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12800" original_id="12800" token="0x6000055" name="set_TimeSlot(string)" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12809" original_id="12809" token="0x6000056" name="get_Status()" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12817" original_id="12817" token="0x6000057" name="set_Status(HealthApp.Model.AppointmentStatus)" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12826" original_id="12826" token="0x6000058" name="get_CancellationReason()" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="12834" original_id="12834" token="0x6000059" name="set_CancellationReason(string)" type_name="Appointment" reason="attribute_excluded" />
        <skipped_function id="13339" original_id="13339" token="0x600005f" name="get_DoctorId()" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13347" original_id="13347" token="0x6000060" name="set_DoctorId(int)" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13356" original_id="13356" token="0x6000061" name="get_FullName()" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13364" original_id="13364" token="0x6000062" name="set_FullName(string)" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13373" original_id="13373" token="0x6000063" name="get_Specialisation()" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13381" original_id="13381" token="0x6000064" name="set_Specialisation(HealthApp.Model.SpecialisationType)" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13390" original_id="13390" token="0x6000065" name="get_DoctorPhoneNo()" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13398" original_id="13398" token="0x6000066" name="set_DoctorPhoneNo(string)" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13407" original_id="13407" token="0x6000067" name="get_DoctorEmail()" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13415" original_id="13415" token="0x6000068" name="set_DoctorEmail(string)" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13424" original_id="13424" token="0x6000069" name="get_YearsOfExperience()" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13432" original_id="13432" token="0x600006a" name="set_YearsOfExperience(int)" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13441" original_id="13441" token="0x600006b" name="get_ConsultationFee()" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13449" original_id="13449" token="0x600006c" name="set_ConsultationFee(decimal)" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13458" original_id="13458" token="0x600006d" name="get_IsActive()" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13466" original_id="13466" token="0x600006e" name="set_IsActive(bool)" type_name="Doctor" reason="attribute_excluded" />
        <skipped_function id="13989" original_id="13989" token="0x6000074" name="get_RecordId()" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="13997" original_id="13997" token="0x6000075" name="set_RecordId(int)" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14006" original_id="14006" token="0x6000076" name="get_Patient()" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14014" original_id="14014" token="0x6000077" name="set_Patient(HealthApp.Model.Patient)" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14023" original_id="14023" token="0x6000078" name="get_Doctor()" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14031" original_id="14031" token="0x6000079" name="set_Doctor(HealthApp.Model.Doctor)" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14040" original_id="14040" token="0x600007a" name="get_VisitDate()" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14048" original_id="14048" token="0x600007b" name="set_VisitDate(System.DateTime)" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14057" original_id="14057" token="0x600007c" name="get_Diagnosis()" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14065" original_id="14065" token="0x600007d" name="set_Diagnosis(string)" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14074" original_id="14074" token="0x600007e" name="get_Prescription()" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14082" original_id="14082" token="0x600007f" name="set_Prescription(string)" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14091" original_id="14091" token="0x6000080" name="get_Notes()" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14099" original_id="14099" token="0x6000081" name="set_Notes(string)" type_name="HealthRecord" reason="attribute_excluded" />
        <skipped_function id="14436" original_id="14436" token="0x6000084" name="get_PatientId()" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14444" original_id="14444" token="0x6000085" name="set_PatientId(int)" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14453" original_id="14453" token="0x6000086" name="get_FullName()" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14461" original_id="14461" token="0x6000087" name="set_FullName(string)" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14470" original_id="14470" token="0x6000088" name="get_DateOfBirth()" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14478" original_id="14478" token="0x6000089" name="set_DateOfBirth(System.DateOnly)" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14487" original_id="14487" token="0x600008a" name="get_Gender()" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14495" original_id="14495" token="0x600008b" name="set_Gender(HealthApp.Model.GenderType)" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14504" original_id="14504" token="0x600008c" name="get_PhoneNumber()" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14512" original_id="14512" token="0x600008d" name="set_PhoneNumber(string)" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14521" original_id="14521" token="0x600008e" name="get_Email()" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14529" original_id="14529" token="0x600008f" name="set_Email(string)" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14538" original_id="14538" token="0x6000090" name="get_InsuranceId()" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14546" original_id="14546" token="0x6000091" name="set_InsuranceId(string)" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14555" original_id="14555" token="0x6000092" name="get_CreatedDate()" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="14563" original_id="14563" token="0x6000093" name="set_CreatedDate(System.DateTime)" type_name="Patient" reason="attribute_excluded" />
        <skipped_function id="22716" original_id="22716" token="0x60000cb" name="get_Appointments()" type_name="AppointmentDb" reason="attribute_excluded" />
        <skipped_function id="22724" original_id="22724" token="0x60000cc" name="set_Appointments(System.Collections.Generic.List&lt;HealthApp.Model.Appointment&gt;)" type_name="AppointmentDb" reason="attribute_excluded" />
        <skipped_function id="22753" original_id="22753" token="0x60000ce" name="get_Doctors()" type_name="DoctorDb" reason="attribute_excluded" />
        <skipped_function id="22761" original_id="22761" token="0x60000cf" name="set_Doctors(System.Collections.Generic.List&lt;HealthApp.Model.Doctor&gt;)" type_name="DoctorDb" reason="attribute_excluded" />
        <skipped_function id="23291" original_id="23291" token="0x60000d1" name="get_Records()" type_name="HealthRecordDb" reason="attribute_excluded" />
        <skipped_function id="23299" original_id="23299" token="0x60000d2" name="set_Records(System.Collections.Generic.List&lt;HealthApp.Model.HealthRecord&gt;)" type_name="HealthRecordDb" reason="attribute_excluded" />
        <skipped_function id="23328" original_id="23328" token="0x60000d4" name="get_Patients()" type_name="PatientDb" reason="attribute_excluded" />
        <skipped_function id="23336" original_id="23336" token="0x60000d5" name="set_Patients(System.Collections.Generic.List&lt;HealthApp.Model.Patient&gt;)" type_name="PatientDb" reason="attribute_excluded" />
      </skipped_functions>
    </module>
  </modules>
  <skipped_modules>
    <skipped_module name="system.private.corelib.dll" path="system.private.corelib.dll" reason="no_symbols" />
    <skipped_module name="dotnet.dll" path="dotnet.dll" reason="no_symbols" />
    <skipped_module name="system.runtime.dll" path="system.runtime.dll" reason="no_symbols" />
    <skipped_module name="system.runtime.interopservices.dll" path="system.runtime.interopservices.dll" reason="no_symbols" />
    <skipped_module name="system.console.dll" path="system.console.dll" reason="no_symbols" />
    <skipped_module name="system.threading.dll" path="system.threading.dll" reason="no_symbols" />
    <skipped_module name="system.text.encoding.extensions.dll" path="system.text.encoding.extensions.dll" reason="no_symbols" />
    <skipped_module name="microsoft.dotnet.cli.utils.dll" path="microsoft.dotnet.cli.utils.dll" reason="no_symbols" />
    <skipped_module name="system.diagnostics.process.dll" path="system.diagnostics.process.dll" reason="no_symbols" />
    <skipped_module name="system.componentmodel.primitives.dll" path="system.componentmodel.primitives.dll" reason="no_symbols" />
    <skipped_module name="microsoft.win32.primitives.dll" path="microsoft.win32.primitives.dll" reason="no_symbols" />
    <skipped_module name="system.diagnostics.tracing.dll" path="system.diagnostics.tracing.dll" reason="no_symbols" />
    <skipped_module name="system.text.encoding.codepages.dll" path="system.text.encoding.codepages.dll" reason="no_symbols" />
    <skipped_module name="system.collections.dll" path="system.collections.dll" reason="no_symbols" />
    <skipped_module name="system.commandline.dll" path="system.commandline.dll" reason="no_symbols" />
    <skipped_module name="system.linq.dll" path="system.linq.dll" reason="no_symbols" />
    <skipped_module name="microsoft.dotnet.configurer.dll" path="microsoft.dotnet.configurer.dll" reason="no_symbols" />
    <skipped_module name="microsoft.dotnet.internalabstractions.dll" path="microsoft.dotnet.internalabstractions.dll" reason="no_symbols" />
    <skipped_module name="system.commandline.staticcompletions.dll" path="system.commandline.staticcompletions.dll" reason="no_symbols" />
    <skipped_module name="microsoft.dotnet.cli.commandline.dll" path="microsoft.dotnet.cli.commandline.dll" reason="no_symbols" />
    <skipped_module name="microsoft.templateengine.cli.dll" path="microsoft.templateengine.cli.dll" reason="no_symbols" />
    <skipped_module name="microsoft.templateengine.edge.dll" path="microsoft.templateengine.edge.dll" reason="no_symbols" />
    <skipped_module name="microsoft.templateengine.abstractions.dll" path="microsoft.templateengine.abstractions.dll" reason="no_symbols" />
    <skipped_module name="microsoft.extensions.logging.abstractions.dll" path="microsoft.extensions.logging.abstractions.dll" reason="no_symbols" />
    <skipped_module name="nuget.commandline.xplat.dll" path="nuget.commandline.xplat.dll" reason="no_symbols" />
    <skipped_module name="spectre.console.dll" path="spectre.console.dll" reason="path_is_excluded" />
    <skipped_module name="nuget.versioning.dll" path="nuget.versioning.dll" reason="no_symbols" />
    <skipped_module name="system.text.json.dll" path="system.text.json.dll" reason="no_symbols" />
    <skipped_module name="nuget.common.dll" path="nuget.common.dll" reason="no_symbols" />
    <skipped_module name="microsoft.dotnet.projecttools.dll" path="microsoft.dotnet.projecttools.dll" reason="no_symbols" />
    <skipped_module name="microsoft.applicationinsights.dll" path="microsoft.applicationinsights.dll" reason="no_symbols" />
    <skipped_module name="microsoft.dotnet.nativewrapper.dll" path="microsoft.dotnet.nativewrapper.dll" reason="no_symbols" />
    <skipped_module name="netstandard.dll" path="netstandard.dll" reason="no_symbols" />
    <skipped_module name="system.collections.immutable.dll" path="system.collections.immutable.dll" reason="no_symbols" />
    <skipped_module name="system.private.uri.dll" path="system.private.uri.dll" reason="no_symbols" />
    <skipped_module name="system.security.cryptography.dll" path="system.security.cryptography.dll" reason="no_symbols" />
    <skipped_module name="system.memory.dll" path="system.memory.dll" reason="no_symbols" />
    <skipped_module name="system.diagnostics.diagnosticsource.dll" path="system.diagnostics.diagnosticsource.dll" reason="no_symbols" />
    <skipped_module name="system.collections.concurrent.dll" path="system.collections.concurrent.dll" reason="no_symbols" />
    <skipped_module name="system.net.http.dll" path="system.net.http.dll" reason="no_symbols" />
    <skipped_module name="system.io.memorymappedfiles.dll" path="system.io.memorymappedfiles.dll" reason="no_symbols" />
    <skipped_module name="system.net.primitives.dll" path="system.net.primitives.dll" reason="no_symbols" />
    <skipped_module name="system.net.security.dll" path="system.net.security.dll" reason="no_symbols" />
    <skipped_module name="microsoft.build.framework.dll" path="microsoft.build.framework.dll" reason="no_symbols" />
    <skipped_module name="system.xml.xdocument.dll" path="system.xml.xdocument.dll" reason="no_symbols" />
    <skipped_module name="microsoft.dotnet.templatelocator.dll" path="microsoft.dotnet.templatelocator.dll" reason="no_symbols" />
    <skipped_module name="system.private.xml.linq.dll" path="system.private.xml.linq.dll" reason="no_symbols" />
    <skipped_module name="system.net.requests.dll" path="system.net.requests.dll" reason="no_symbols" />
    <skipped_module name="msbuild.dll" path="msbuild.dll" reason="no_symbols" />
    <skipped_module name="microsoft.deployment.dotnet.releases.dll" path="microsoft.deployment.dotnet.releases.dll" reason="no_symbols" />
    <skipped_module name="system.threading.thread.dll" path="system.threading.thread.dll" reason="no_symbols" />
    <skipped_module name="system.net.networkinformation.dll" path="system.net.networkinformation.dll" reason="no_symbols" />
    <skipped_module name="microsoft.build.dll" path="microsoft.build.dll" reason="no_symbols" />
    <skipped_module name="system.xml.readerwriter.dll" path="system.xml.readerwriter.dll" reason="no_symbols" />
    <skipped_module name="microsoft.win32.registry.dll" path="microsoft.win32.registry.dll" reason="no_symbols" />
    <skipped_module name="system.private.xml.dll" path="system.private.xml.dll" reason="no_symbols" />
    <skipped_module name="system.text.regularexpressions.dll" path="system.text.regularexpressions.dll" reason="no_symbols" />
    <skipped_module name="system.runtime.loader.dll" path="system.runtime.loader.dll" reason="no_symbols" />
    <skipped_module name="system.diagnostics.fileversioninfo.dll" path="system.diagnostics.fileversioninfo.dll" reason="no_symbols" />
    <skipped_module name="system.net.nameresolution.dll" path="system.net.nameresolution.dll" reason="no_symbols" />
    <skipped_module name="system.runtime.intrinsics.dll" path="system.runtime.intrinsics.dll" reason="no_symbols" />
    <skipped_module name="microsoft.net.stringtools.dll" path="microsoft.net.stringtools.dll" reason="no_symbols" />
    <skipped_module name="system.io.compression.dll" path="system.io.compression.dll" reason="no_symbols" />
    <skipped_module name="system.threading.tasks.dataflow.dll" path="system.threading.tasks.dataflow.dll" reason="no_symbols" />
    <skipped_module name="nuget.protocol.dll" path="nuget.protocol.dll" reason="no_symbols" />
    <skipped_module name="nuget.configuration.dll" path="nuget.configuration.dll" reason="no_symbols" />
    <skipped_module name="microsoft.visualstudio.solutionpersistence.dll" path="microsoft.visualstudio.solutionpersistence.dll" reason="no_symbols" />
    <skipped_module name="nuget.credentials.dll" path="nuget.credentials.dll" reason="no_symbols" />
    <skipped_module name="system.serviceprocess.servicecontroller.dll" path="system.serviceprocess.servicecontroller.dll" reason="no_symbols" />
    <skipped_module name="system.security.principal.windows.dll" path="system.security.principal.windows.dll" reason="no_symbols" />
    <skipped_module name="system.security.claims.dll" path="system.security.claims.dll" reason="no_symbols" />
    <skipped_module name="system.threading.tasks.parallel.dll" path="system.threading.tasks.parallel.dll" reason="no_symbols" />
    <skipped_module name="system.numerics.vectors.dll" path="system.numerics.vectors.dll" reason="no_symbols" />
    <skipped_module name="microsoft.build.tasks.core.dll" path="microsoft.build.tasks.core.dll" reason="no_symbols" />
    <skipped_module name="microsoft.build.utilities.core.dll" path="microsoft.build.utilities.core.dll" reason="no_symbols" />
    <skipped_module name="nuget.build.tasks.dll" path="nuget.build.tasks.dll" reason="no_symbols" />
    <skipped_module name="system.reflection.metadata.dll" path="system.reflection.metadata.dll" reason="no_symbols" />
    <skipped_module name="nuget.commands.dll" path="nuget.commands.dll" reason="no_symbols" />
    <skipped_module name="system.threading.threadpool.dll" path="system.threading.threadpool.dll" reason="no_symbols" />
    <skipped_module name="nuget.projectmodel.dll" path="nuget.projectmodel.dll" reason="no_symbols" />
    <skipped_module name="system.net.sockets.dll" path="system.net.sockets.dll" reason="no_symbols" />
    <skipped_module name="system.threading.overlapped.dll" path="system.threading.overlapped.dll" reason="no_symbols" />
    <skipped_module name="system.io.pipes.dll" path="system.io.pipes.dll" reason="no_symbols" />
    <skipped_module name="microsoft.build.nugetsdkresolver.dll" path="microsoft.build.nugetsdkresolver.dll" reason="no_symbols" />
    <skipped_module name="system.security.accesscontrol.dll" path="system.security.accesscontrol.dll" reason="no_symbols" />
    <skipped_module name="microsoft.net.sdk.workloadmsbuildsdkresolver.dll" path="microsoft.net.sdk.workloadmsbuildsdkresolver.dll" reason="no_symbols" />
    <skipped_module name="microsoft.net.sdk.workloadmanifestreader.dll" path="microsoft.net.sdk.workloadmanifestreader.dll" reason="no_symbols" />
    <skipped_module name="nuget.frameworks.dll" path="nuget.frameworks.dll" reason="no_symbols" />
    <skipped_module name="system.collections.nongeneric.dll" path="system.collections.nongeneric.dll" reason="no_symbols" />
    <skipped_module name="microsoft.net.build.tasks.dll" path="microsoft.net.build.tasks.dll" reason="no_symbols" />
    <skipped_module name="nuget.packaging.dll" path="nuget.packaging.dll" reason="no_symbols" />
    <skipped_module name="newtonsoft.json.dll" path="newtonsoft.json.dll" reason="no_symbols" />
    <skipped_module name="system.linq.expressions.dll" path="system.linq.expressions.dll" reason="no_symbols" />
    <skipped_module name="system.componentmodel.typeconverter.dll" path="system.componentmodel.typeconverter.dll" reason="no_symbols" />
    <skipped_module name="system.objectmodel.dll" path="system.objectmodel.dll" reason="no_symbols" />
    <skipped_module name="nuget.librarymodel.dll" path="nuget.librarymodel.dll" reason="no_symbols" />
    <skipped_module name="nuget.dependencyresolver.core.dll" path="nuget.dependencyresolver.core.dll" reason="no_symbols" />
    <skipped_module name="system.runtime.serialization.primitives.dll" path="system.runtime.serialization.primitives.dll" reason="no_symbols" />
    <skipped_module name="system.runtime.numerics.dll" path="system.runtime.numerics.dll" reason="no_symbols" />
    <skipped_module name="system.text.encodings.web.dll" path="system.text.encodings.web.dll" reason="no_symbols" />
    <skipped_module name="system.reflection.emit.lightweight.dll" path="system.reflection.emit.lightweight.dll" reason="no_symbols" />
    <skipped_module name="system.reflection.primitives.dll" path="system.reflection.primitives.dll" reason="no_symbols" />
    <skipped_module name="system.reflection.emit.ilgeneration.dll" path="system.reflection.emit.ilgeneration.dll" reason="no_symbols" />
    <skipped_module name="microsoft.testplatform.build.dll" path="microsoft.testplatform.build.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.build.tasks.codeanalysis.dll" path="microsoft.build.tasks.codeanalysis.dll" reason="no_symbols" />
    <skipped_module name="microsoft.build.tasks.git.dll" path="microsoft.build.tasks.git.dll" reason="no_symbols" />
    <skipped_module name="microsoft.sourcelink.common.dll" path="microsoft.sourcelink.common.dll" reason="no_symbols" />
    <skipped_module name="microsoft.sourcelink.github.dll" path="microsoft.sourcelink.github.dll" reason="no_symbols" />
    <skipped_module name="microsoft.sourcelink.gitlab.dll" path="microsoft.sourcelink.gitlab.dll" reason="no_symbols" />
    <skipped_module name="microsoft.sourcelink.azurerepos.git.dll" path="microsoft.sourcelink.azurerepos.git.dll" reason="no_symbols" />
    <skipped_module name="microsoft.sourcelink.bitbucket.git.dll" path="microsoft.sourcelink.bitbucket.git.dll" reason="no_symbols" />
    <skipped_module name="sonarscanner.msbuild.tasks.dll" path="sonarscanner.msbuild.tasks.dll" reason="no_symbols" />
    <skipped_module name="sonarscanner.msbuild.common.dll" path="sonarscanner.msbuild.common.dll" reason="no_symbols" />
    <skipped_module name="system.xml.xmlserializer.dll" path="system.xml.xmlserializer.dll" reason="no_symbols" />
    <skipped_module name="system.diagnostics.tracesource.dll" path="system.diagnostics.tracesource.dll" reason="no_symbols" />
    <skipped_module name="system.collections.specialized.dll" path="system.collections.specialized.dll" reason="no_symbols" />
    <skipped_module name="system.reflection.emit.dll" path="system.reflection.emit.dll" reason="no_symbols" />
    <skipped_module name="microsoft.net.hostmodel.dll" path="microsoft.net.hostmodel.dll" reason="no_symbols" />
    <skipped_module name="vstest.console.dll" path="vstest.console.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.testplatform.coreutilities.dll" path="microsoft.testplatform.coreutilities.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.testplatform.platformabstractions.dll" path="microsoft.testplatform.platformabstractions.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.visualstudio.testplatform.objectmodel.dll" path="microsoft.visualstudio.testplatform.objectmodel.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.visualstudio.testplatform.common.dll" path="microsoft.visualstudio.testplatform.common.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.testplatform.utilities.dll" path="microsoft.testplatform.utilities.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.extensions.filesystemglobbing.dll" path="microsoft.extensions.filesystemglobbing.dll" reason="no_symbols" />
    <skipped_module name="microsoft.testplatform.crossplatengine.dll" path="microsoft.testplatform.crossplatengine.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.visualstudio.testplatform.client.dll" path="microsoft.visualstudio.testplatform.client.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.diagnostics.netcore.client.dll" path="microsoft.diagnostics.netcore.client.dll" reason="no_symbols" />
    <skipped_module name="system.threading.tasks.extensions.dll" path="system.threading.tasks.extensions.dll" reason="no_symbols" />
    <skipped_module name="system.diagnostics.stacktrace.dll" path="system.diagnostics.stacktrace.dll" reason="no_symbols" />
    <skipped_module name="microsoft.testplatform.extensions.blamedatacollector.dll" path="microsoft.testplatform.extensions.blamedatacollector.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.testplatform.extensions.eventlogcollector.dll" path="microsoft.testplatform.extensions.eventlogcollector.dll" reason="path_is_excluded" />
    <skipped_module name="mscorlib.dll" path="mscorlib.dll" reason="path_is_excluded" />
    <skipped_module name="system.xml.dll" path="system.xml.dll" reason="no_symbols" />
    <skipped_module name="microsoft.testplatform.testhostruntimeprovider.dll" path="microsoft.testplatform.testhostruntimeprovider.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.visualstudio.testplatform.extensions.html.testlogger.dll" path="microsoft.visualstudio.testplatform.extensions.html.testlogger.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.visualstudio.testplatform.extensions.trx.testlogger.dll" path="microsoft.visualstudio.testplatform.extensions.trx.testlogger.dll" reason="path_is_excluded" />
    <skipped_module name="microsoft.testplatform.communicationutilities.dll" path="microsoft.testplatform.communicationutilities.dll" reason="path_is_excluded" />
    <skipped_module name="system.runtime.serialization.formatters.dll" path="system.runtime.serialization.formatters.dll" reason="no_symbols" />
    <skipped_module name="microsoft.testplatform.vstestconsole.translationlayer.dll" path="microsoft.testplatform.vstestconsole.translationlayer.dll" reason="path_is_excluded" />
    <skipped_module name="testhost.dll" path="testhost.dll" reason="path_is_excluded" />
    <skipped_module name="system.data.common.dll" path="system.data.common.dll" reason="no_symbols" />
    <skipped_module name="system.componentmodel.dll" path="system.componentmodel.dll" reason="no_symbols" />
    <skipped_module name="xunit.runner.visualstudio.testadapter.dll" path="xunit.runner.visualstudio.testadapter.dll" reason="path_is_excluded" />
    <skipped_module name="xunit.abstractions.dll" path="xunit.abstractions.dll" reason="public_key_token_is_excluded" />
    <skipped_module name="xunit.execution.dotnet.dll" path="xunit.execution.dotnet.dll" reason="path_is_excluded" />
    <skipped_module name="system.reflection.dll" path="system.reflection.dll" reason="no_symbols" />
    <skipped_module name="system.runtime.extensions.dll" path="system.runtime.extensions.dll" reason="no_symbols" />
    <skipped_module name="xunit.core.dll" path="xunit.core.dll" reason="path_is_excluded" />
    <skipped_module name="system.globalization.dll" path="system.globalization.dll" reason="no_symbols" />
    <skipped_module name="system.reflection.extensions.dll" path="system.reflection.extensions.dll" reason="no_symbols" />
    <skipped_module name="system.threading.tasks.dll" path="system.threading.tasks.dll" reason="no_symbols" />
    <skipped_module name="system.io.dll" path="system.io.dll" reason="no_symbols" />
    <skipped_module name="system.text.encoding.dll" path="system.text.encoding.dll" reason="no_symbols" />
    <skipped_module name="moq.dll" path="moq.dll" reason="path_is_excluded" />
    <skipped_module name="castle.core.dll" path="castle.core.dll" reason="no_symbols" />
    <skipped_module name="xunit.assert.dll" path="xunit.assert.dll" reason="path_is_excluded" />
  </skipped_modules>
</results>