# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
csharp: true
library-name: Orbital
namespace: Azure.ResourceManager.Orbital
require: https://github.com/Azure/azure-rest-api-specs/blob/e686ed79e9b0bbc10355fd8d7ba36d1a07e4ba28/specification/orbital/resource-manager/readme.md
tag: package-2022-03-01
output-folder: $(this-folder)/Generated
clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false

rename-mapping:
  EndPoint.ipAddress: -|ip-address
  ContactProfilesPropertiesNetworkConfiguration.subnetId: NetworkSubnetId|arm-id
  AuthorizedGroundstation.groundStation: GroundStationName
  AuthorizedGroundstation: AuthorizedGroundStation
  CapabilityParameter: GroundStationCapability
  Contact: OrbitalContact
  ContactListResult: OrbitalContactListResult
  ContactProfile: OrbitalContactProfile
  ContactProfileLink: OrbitalContactProfileLink
  ContactProfileLinkChannel: OrbitalContactProfileLinkChannel
  ContactProfilesPropertiesProvisioningState: OrbitalProvisioningState
  ContactsPropertiesProvisioningState: OrbitalProvisioningState
  SpacecraftsPropertiesProvisioningState: OrbitalProvisioningState
  ContactsPropertiesAntennaConfiguration: OrbitalContactAntennaConfiguration
  ContactsStatus: OrbitalContactStatus
  Direction: OrbitalLinkDirection
  EndPoint: OrbitalContactEndpoint
  Polarization: OrbitalLinkPolarization
  Protocol: OrbitalContactProtocol
  ReleaseMode: GroundStationReleaseMode
  Spacecraft: OrbitalSpacecraft
  SpacecraftLink: OrbitalSpacecraftLink
  SpacecraftListResult: OrbitalSpacecraftListResult
  TagsObject: OrbitalSpacecraftTags

format-by-name-rules:
  'sourceIPs': 'ip-address'
  'destinationIP': 'ip-address'
  'tenantId': 'uuid'
  'ETag': 'etag'
  'location': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'

rename-rules:
  CPU: Cpu
  CPUs: Cpus
  Os: OS
  Ip: IP
  Ips: IPs|ips
  ID: Id
  IDs: Ids
  VM: Vm
  VMs: Vms
  Vmos: VmOS
  VMScaleSet: VmScaleSet
  DNS: Dns
  VPN: Vpn
  NAT: Nat
  WAN: Wan
  Ipv4: IPv4|ipv4
  Ipv6: IPv6|ipv6
  Ipsec: IPsec|ipsec
  SSO: Sso
  URI: Uri
  Etag: ETag|etag
  UDP: Udp
  TCP: Tcp

directive:
  - from: orbital.json
    where: $.definitions
    transform: >
      $.AvailableGroundStationProperties['x-ms-client-name'] = 'GroundStationProperties';
      $.ContactProfilesProperties.properties.minimumViableContactDuration['format'] = 'duration';
  - remove-operation: Spacecrafts_ListAvailableContacts
  - remove-operation: OperationsResults_Get
```